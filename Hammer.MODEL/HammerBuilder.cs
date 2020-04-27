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
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangle(_hammerParameters.HeadParameters.Width, _hammerParameters.HeadParameters.Length);
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Width);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.FigureCutBySketch(_hammerParameters.HeadParameters.Width, false);
            _solidWorksApi.RemoveAllocations();
        }

        private void CreateHandle()
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.CoordinatesSelection(0, 0, 0);

            _solidWorksApi.DrawingCircle(3);
            _solidWorksApi.FigureElongationBySketch(50);
        }
    }
}
