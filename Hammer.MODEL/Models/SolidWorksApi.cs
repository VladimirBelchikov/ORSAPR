﻿using System;

using SolidWorks.Interop.sldworks;

using Hammer.MODEL.Enum;


namespace Hammer.MODEL.Models
{
    public class SolidWorksApi
    {
        private SldWorks _solidWorks;
        private IModelDoc2 _model;
        private const string SelectionAxisType = "PLANE";

        // Я не знаю, что именно делают эти "магические числа",
        // но если что-то из этого поменять, то Солид не будет строить деталь.
        // http://help.solidworks.com/2016/English/api/sldworksapi/SolidWorks.Interop.sldworks~SolidWorks.Interop.sldworks.IModelDoc2~FeatureCut.html
        // https://help.solidworks.com/2017/english/api/sldworksapi/solidworks.interop.sldworks~solidworks.interop.sldworks.ipartdoc~featureextrusion2.html
        // Ссылки на документацию к методам API, даже в них нет пояснений параметрам!
        // НЕ ТРОГАТЬ!!!!!!!
        private const double Dang = 1.74532925199433E-02;
        private const int T = 0;
        private const double D2 = 0.01;
        private const int StartOffSet = 0;

        /// <summary>
        /// Инициализация SolidWorks
        /// </summary>
        /// <returns></returns>
        public object IsThereSolidWorks()
        {
            try
            {
	            var processSolidWorks = Activator.CreateInstance
	                (Type.GetTypeFromProgID("SldWorks.Application.28"));
                return processSolidWorks;
            }
            catch
            {
                throw new Exception(
	                "SolidWorks 2020 not found on your PC");
            }
        }

        /// <summary>
        /// Метод запуска SolidWorks
        /// </summary>
        /// <param name="processSolidWorks"></param>
        public void StartSolidWorks(object processSolidWorks)
        {
            _solidWorks = (SldWorks)processSolidWorks;
            _solidWorks.Visible = true;
        }

        /// <summary>
        /// Метод для создания плоскости
        /// </summary>
        public void CreatePlane()
        {
            _model.CreatePlaneAtOffset3(10, true, true);
        }

        /// <summary>
        /// Метод отрисовки линии
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="z1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        public void DrawingLine(double x1, double y1, double z1, double x2,
	        double y2, double z2)
        {
            _model.SketchManager.CreateLine(x1, y1, z1, x2, y2, z2);
        }

        /// <summary>
        /// Метод отрисовки углового прямоугольника
        /// </summary>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public void DrawingCornerRectangle(double x2, double y2)
        {
            _model.SketchManager.CreateCornerRectangle(0, 0, 0, x2,
	            y2, 0);
        }

        /// <summary>
        /// Метод отрисовки круга
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="radius"></param>
        public void DrawingCircleByRadius(double x, double y, double z,
	        double radius)
        {
            _model.SketchManager.CreateCircleByRadius(x, y, z,
	            radius);
        }

        /// <summary>
        /// Метод для создания ногово файла в SolidWorks
        /// </summary>
        public void CreateSolidWorksFile()
        {
            _solidWorks.NewPart();
            _model = _solidWorks.IActiveDoc2;
        }

        /// <summary>
        /// Метод выбора вида
        /// </summary>
        /// <param name="planeView"></param>
        public void LayerSelection(PlaneView planeView)
        {
            switch (planeView)
            {
                case PlaneView.TopAxisName:
                    _model.Extension.SelectByID2("Сверху", SelectionAxisType,
	                    0, 0, 0, false, 0, null, 0);
                    break;
                case PlaneView.FrontAxisName:
                    _model.Extension.SelectByID2("Спереди", SelectionAxisType,
	                    0, 0, 0, false, 0, null, 0);
                    break;
                case PlaneView.RightAxisName:
                    _model.Extension.SelectByID2("Справа", SelectionAxisType,
	                    0, 0, 0, false, 0, null, 0);
                    break;
            }
        }

        /// <summary>
        /// Метод выбора эскиза
        /// </summary>
        public void SketchSelection()
        {
            _model.SketchManager.InsertSketch(true);
        }

        /// <summary>
        /// Метод сброса заданной позиции
        /// </summary>
        public void RemoveAllocations()
        {
            _model.ClearSelection2(true);
        }

        /// <summary>
        /// Метод для выреза по параметрам
        /// </summary>
        /// <param name="length"></param>
        public void FigureCutBySketch(double length)
        {
            _model.FeatureManager.FeatureCut(true, false, true, T, T, length,
	            D2, false, false, false,false, Dang, Dang, false, false, false,
	            false, false, true, true);
        }

        /// <summary>
        /// Метод для вытягивания по параметрам
        /// </summary>
        /// <param name="length"></param>
        public void FigureElongationBySketch(double length)
        {
	        _model.FeatureManager.FeatureExtrusion2(true, false, false, T, T,
		        length, D2, false, false, false, false, Dang, Dang, false,
		        false, false, false, true, true, true, T, StartOffSet, false);
        }
    }
}