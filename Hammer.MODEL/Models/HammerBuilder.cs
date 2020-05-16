using Hammer.MODEL.Enum;
using Hammer.MODEL.Models;

namespace Hammer.MODEL
{
    public class HammerBuilder
    {
        private readonly HammerParameters _hammerParameters;
        private readonly SolidWorksApi _solidWorksApi;
        private readonly object _solidWorks;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="hammerParameters"></param>
        public HammerBuilder(HammerParameters hammerParameters)
        {
            _hammerParameters = hammerParameters;

            _solidWorksApi = new SolidWorksApi(); 
            
            _solidWorks = _solidWorksApi.IsThereSolidWorks();
        }

        /// <summary>
        /// Создание пустого файла в SolidWorks
        /// </summary>
        public void CreateFile()
        {
            _solidWorksApi.CreateSolidWorksFile();
        }

        /// <summary>
        /// Открытие SolidWorks
        /// </summary>
        public void OpenSolidWorks()
        {
            _solidWorksApi.StartSolidWorks(_solidWorks);
        }

        /// <summary>
        /// Метод для создания молотка
        /// </summary>
        public void CreateHammerWithToeHead()
        {
            CreateFile();
            CreateHeadWithToe();
            CreateHandle();
        }

        /// <summary>
        /// Метод для создания молотка с наконечник на оголовье
        /// </summary>
        public void CreateHammerWithPeenHead()
        {
            CreateFile();
            CreateHeadWithPeen();
            CreateHandle();
        }
        
        /// <summary>
        /// Метод для создания молотка с двусторонним бойком
        /// </summary>
        private void CreateHeadWithPeen()
        { 

            PlaneSelection(PlaneView.FrontAxisName);

            _solidWorksApi.DrawingCornerRectangle(_hammerParameters.HeadParameters.Height, _hammerParameters.HeadParameters.Width);
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Length);

            //_solidWorksApi.DrawingCornerRectangle(_hammerParameters.HeadParameters.Height, _hammerParameters.HeadParameters.Width);
            //_solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Length * -1);
            
        }

        /// <summary>
        /// Метод для создания оголовья
        /// </summary>
        private void CreateHeadWithToe()
        {
            
            // Отрисовка наконечника
            PlaneSelection(PlaneView.TopAxisName);

            _solidWorksApi.DrawingLine(0, 0, 0, _hammerParameters.HeadParameters.Height, 0, 0);
            _solidWorksApi.DrawingLine(_hammerParameters.HeadParameters.Height, 0, 0, (_hammerParameters.HeadParameters.Height / 2) + (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0);
            _solidWorksApi.DrawingLine((_hammerParameters.HeadParameters.Height / 2) + (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0, (_hammerParameters.HeadParameters.Height / 2) - (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0);
            _solidWorksApi.DrawingLine((_hammerParameters.HeadParameters.Height / 2) - (_hammerParameters.HeadParameters.TipWidth / 2), _hammerParameters.HeadParameters.ToeLength, 0, 0, 0, 0);
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Width);

            // Отрисовка основной части
            PlaneSelection(PlaneView.FrontAxisName);

            _solidWorksApi.DrawingCornerRectangle(_hammerParameters.HeadParameters.Height, _hammerParameters.HeadParameters.Width);
            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HeadParameters.Length);

            // Вырез под рукоять
            PlaneSelection(PlaneView.RightAxisName);

            _solidWorksApi.DrawingCircleByRadius(
                -1 * (_hammerParameters.HeadParameters.Length) / _hammerParameters.Denominator,
                _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Diameter / 2);


            //if (_hammerParameters.HandleParameters.Diameter > 24)
            //{
            //    _solidWorksApi.DrawingCircleByRadius(-16, _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Diameter / 2);
            //}
            //else
            //{
            //    _solidWorksApi.DrawingCircleByRadius(-12, _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Diameter / 2);
            //}
            _solidWorksApi.FigureCutBySketch(_hammerParameters.HeadParameters.Width);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.RemoveAllocations();
        }

        /// <summary>
        /// Метод для создания рукояти
        /// </summary>
        private void CreateHandle()
        {
            PlaneSelection(PlaneView.RightAxisName);

            _solidWorksApi.DrawingCircleByRadius(
                -1 * (_hammerParameters.HeadParameters.Length) / _hammerParameters.Denominator,
                _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Diameter / 2);


            //if (_hammerParameters.HandleParameters.Diameter > 24)
            //{
            //    _solidWorksApi.DrawingCircleByRadius(-16, _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Diameter / 2);
            //}
            //else
            //{
            //    _solidWorksApi.DrawingCircleByRadius(-12, _hammerParameters.HeadParameters.Width / 2, 0, _hammerParameters.HandleParameters.Diameter / 2);
            //}

            _solidWorksApi.FigureElongationBySketch(_hammerParameters.HandleParameters.Length);
        }

        /// <summary>
        ///Выбор плоскости
        /// </summary>
        /// <param name="planeView"></param>
        private void PlaneSelection(PlaneView planeView)
        {
            _solidWorksApi.CreatePlane();
            _solidWorksApi.LayerSelection(planeView);
            _solidWorksApi.SketchSelection();
        }
    }
}
