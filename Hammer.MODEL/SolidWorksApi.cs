﻿using System;
using SolidWorks.Interop.sldworks;

namespace Hammer.MODEL
{
    public class SolidWorksApi
    {
        private SldWorks _solidWorks;

        private IModelDoc2 _model;

        private const string SelectionAxisType = "PLANE";


        public object IsThereSolidWorks()
        {
            try
            {
                Guid guid = new Guid("d134b411-3689-497d-b2d7-a27cb1066648");
                object processSolidWorks = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(guid));
                return processSolidWorks;
            }
            catch
            {
                throw new Exception("SolidWorks 2020 не найден на вашем компьютере");
            }
        }

        public void StartSolidWorks(object processSolidWorks)
        {
            _solidWorks = (SldWorks)processSolidWorks;
            _solidWorks.Visible = true;
        }

        public void CreatePlane()
        {
            _model.CreatePlaneAtOffset3(10, true, true);
        }
        public void DrawingLine(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            _model.SketchManager.CreateLine(x1, y1, z1, x2, y2, z2);
        }

        public void DrawingRectangle(int xaxis, int yaxis, int center = 0)
        {
            _model.SketchManager.CreateCenterRectangle(center, 0, 0, xaxis / 2, yaxis / 2, 0);
        }

        public void DrawingCircleByRadius(double x, double y, double z, double radius)
        {
            _model.SketchManager.CreateCircleByRadius(x, y, z, radius);
        }

        public void CreateSolidWorksFile()
        {
            _solidWorks.NewPart();
            _model = _solidWorks.IActiveDoc2;
        }

        public void LayerSelection(PlaneView planeView)
        {
            if (planeView == PlaneView.TopAxisName)
            {
                _model.Extension.SelectByID2("Сверху", SelectionAxisType, 0, 0, 0, false, 0, null, 0);
            }
            if (planeView == PlaneView.FrontAxisName)
            {
                _model.Extension.SelectByID2("Спереди", SelectionAxisType, 0, 0, 0, false, 0, null, 0);
            }
            if (planeView == PlaneView.RightAxisName)
            {
                _model.Extension.SelectByID2("Справа", SelectionAxisType, 0, 0, 0, false, 0, null, 0);
            }
        }


        

        public void SketchSelection()
        {
            _model.SketchManager.InsertSketch(true);
        }

        public void RemoveAllocations()
        {
            _model.ClearSelection2(true);
        }

        public void FigureCutBySketch(int height, bool upDirection = true)
        {
            _model.FeatureManager.FeatureCut4(true, false, upDirection, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
        }

        public void FigureElongationBySketch(int height)
        {
            _model.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
        }

    }
}