using Hammer.MODEL.Models;

namespace Hammer.MODEL
{
    public class HammerBuilder
    {
        private readonly HammerParameters _hammerParameters;
        private readonly SolidWorksApi _solidWorksApi;

        private readonly object _solidWorks;

        public HammerBuilder(HammerParameters hammerParameters)
        {
            _hammerParameters = hammerParameters;

            _solidWorksApi = new SolidWorksApi();

            _solidWorks = _solidWorksApi.IsThereSolidWorks();
        }

        public void OpenSolidWorks()
        {
            _solidWorksApi.StartSolidWorks(_solidWorks);
        }

        public void CreateHammer()
        {
            _solidWorksApi.CreateSolidWorksFile();

            CreateHead();
            CreateHandle();
        }
        private void CreateHead()
        {
            _solidWorksApi.LayerSelection(PlaneView.TopAxisName);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingLine(0, 0, 0, _hammerParameters.HeadParameters.Width, 0, 0);
            _solidWorksApi.DrawingLine(_hammerParameters.HeadParameters.Width, 0, 0, (_hammerParameters.HeadParameters.Width / 2) + (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0);
            _solidWorksApi.DrawingLine((_hammerParameters.HeadParameters.Width / 2) + (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0, (_hammerParameters.HeadParameters.Width / 2) - (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0);
            _solidWorksApi.DrawingLine((_hammerParameters.HeadParameters.Width / 2) - (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0, 0, 0, 0);
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Width);


            _solidWorksApi.LayerSelection(PlaneView.FrontAxisName);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingLine(0, 0, 0, _hammerParameters.HeadParameters.Width, 0, 0);
            _solidWorksApi.DrawingLine(_hammerParameters.HeadParameters.Width, 0, 0, _hammerParameters.HeadParameters.Width, _hammerParameters.HeadParameters.Width, 0);
            _solidWorksApi.DrawingLine(_hammerParameters.HeadParameters.Width, _hammerParameters.HeadParameters.Width, 0, 0, _hammerParameters.HeadParameters.Width, 0);
            _solidWorksApi.DrawingLine(0, _hammerParameters.HeadParameters.Width, 0, 0, 0, 0);
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Length);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.RemoveAllocations();
        }

        private void CreateHandle()
        {
            _solidWorksApi.CreatePlane();
            _solidWorksApi.LayerSelection(PlaneView.RightAxisName);
            _solidWorksApi.SketchSelection();
            if (_hammerParameters.HandleParameters.Width > 24)
            {
                _solidWorksApi.DrawingCircleByRadius(-16, _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Width / 2);
            }
            else
            {
                _solidWorksApi.DrawingCircleByRadius(-12, _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Width / 2);
            }
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HandleParameters.Height);
        }
    }
}
