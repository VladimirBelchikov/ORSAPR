using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _solidWorksApi.LayerSelection(1);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingLine(0, 0, 0, _hammerParameters.HeadParameters.Width, 0, 0);
            _solidWorksApi.DrawingLine(_hammerParameters.HeadParameters.Width, 0, 0, (_hammerParameters.HeadParameters.Width / 2) + (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0);
            _solidWorksApi.DrawingLine((_hammerParameters.HeadParameters.Width / 2) + (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0, (_hammerParameters.HeadParameters.Width / 2) - (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0);
            _solidWorksApi.DrawingLine((_hammerParameters.HeadParameters.Width / 2) - (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0, 0, 0, 0);

            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Width);

            _solidWorksApi.LayerSelection(2);
            _solidWorksApi.SketchSelection();


            _solidWorksApi.DrawingLine(0, 0, 0, _hammerParameters.HeadParameters.Width, 0, 0);
            _solidWorksApi.DrawingLine(_hammerParameters.HeadParameters.Width, 0, 0, _hammerParameters.HeadParameters.Width, _hammerParameters.HeadParameters.Width, 0);
            _solidWorksApi.DrawingLine(_hammerParameters.HeadParameters.Width, _hammerParameters.HeadParameters.Width, 0, 0, _hammerParameters.HeadParameters.Width, 0);
            _solidWorksApi.DrawingLine(0, _hammerParameters.HeadParameters.Width, 0, 0, 0, 0);

            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Length);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.FigureCutBySketch(_hammerParameters.HeadParameters.Width, false);
            _solidWorksApi.RemoveAllocations();
            _solidWorksApi.LayerSelection(2);
        }

        private void CreateHandle()
        {
            _solidWorksApi.LayerSelection(3);
            _solidWorksApi.SketchSelection();

            _solidWorksApi.CoordinatesSelection(0, (_hammerParameters.HeadParameters.Width / 2), 10);

            _solidWorksApi.DrawingCircle(0, (_hammerParameters.HeadParameters.Width / 2), 0, _hammerParameters.HandleParameters.Width);
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HandleParameters.Length);
        }
    }
}
