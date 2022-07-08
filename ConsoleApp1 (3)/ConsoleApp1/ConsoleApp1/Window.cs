
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Windowing.Desktop;
using System;
using OpenTK.Mathematics;
using LearnOpenTK.Common;

namespace ConsoleApp1
{
    class Window : GameWindow

    {
        static class Constants
        {
            public const string path = "../../../Shaders/";
        }
        List<Asset3d> objectList = new List<Asset3d>();
        List<Asset3d> objectList2 = new List<Asset3d>();
        List<Asset3d> objectList3 = new List<Asset3d>();
        List<Asset3d> objectListAlvin = new List<Asset3d>();
        List<Asset3d> objectListEnvironment = new List<Asset3d>();
        List<Asset3d> objectListCloud = new List<Asset3d>();
        List<Asset3d> objectListCloud2 = new List<Asset3d>();
        List<Asset3d> objectListPintuDepan = new List<Asset3d>();
        List<Asset3d> objectListPintuDepan2 = new List<Asset3d>();
        List<Asset3d> objectListPintuKandangKucing = new List<Asset3d>();
        List<Asset3d> objectListPintuKandangPanda = new List<Asset3d>();
        List<Asset3d> objectListPintuKandangBabi = new List<Asset3d>();
        List<Asset3d> StickMan = new List<Asset3d>();



        Asset3d LightObject = new Asset3d(new Vector3(1, 1, 1));




        float berhenti = 1001;
        float berhenti1 = 0;
        float berhentiobject = 0;
        float berhentiobjectTemp = 901;

        float AwalPosisiPanda = 0;
        float RotasiPanda = 0;


        float berhenticloud = 0;
        float berhenticloud1 = 0;
        float berhentiPagar = 901;
        float berhentiPagar2 = 0;

        float KucingTranslasi = 0;
        float PandaTranslasi = 0;
        float BabiTranslasi = 0;



        float berhentiPagarKucing = 901;

        float berhentiPagarPanda = 901;
        float berhentiPagarBabi = 901;

        bool walking = false;
        bool headDir = true;


        List<Asset3d> objectListHans = new List<Asset3d>();
        Camera _camera;
        Matrix4 anim = Matrix4.Identity;
        Matrix4 anim2 = Matrix4.Identity;
        Matrix4 anim3 = Matrix4.Identity;
        Matrix4 anim4 = Matrix4.Identity;
        Matrix4 Cloud = Matrix4.Identity;
        Matrix4 Cloud2 = Matrix4.Identity;
        Matrix4 PintuDepan = Matrix4.Identity;
        Matrix4 PintuDepan2 = Matrix4.Identity;
        Matrix4 PintuKandangKucing = Matrix4.Identity;

        Matrix4 PintuKandangPanda = Matrix4.Identity;

        Matrix4 PintuKandangBabi = Matrix4.Identity;
        Matrix4 MatStickMan = Matrix4.Identity;




        Vector2 _lastPos;
        bool _firstMove = true;


        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {

        }

        protected override void OnLoad()
        {
            base.OnLoad();
            _camera = new Camera(new Vector3(4.5f,-5, 30), Size.X / Size.Y);
            GL.ClearColor(0.3f, 0.4f, 0.6f, 1.0f);
            GL.Enable(EnableCap.DepthTest);
            
            var LightObject = new Asset3d(new Vector3(0,0,0));
            //toni
            var cube1 = new Asset3d(new Vector3(1, 1, 1));
            var cuberand = new Asset3d(new Vector3(1, 1, 1));

            var persegipanjang = new Asset3d(new Vector3(1, 1, 1));
            var persegipanjang2 = new Asset3d(new Vector3(1, 1, 1));
            var persegipanjang3= new Asset3d(new Vector3(1, 1, 1));
            var persegipanjang4= new Asset3d(new Vector3(1, 1, 1));
            var persegipanjang5= new Asset3d(new Vector3(1, 1, 1));



            var cube2 = new Asset3d(new Vector3(0, 0, 0));
            var cube3 = new Asset3d(new Vector3(0, 0, 0));
            var cube4 = new Asset3d(new Vector3(0.95f, 0.2f, 0.4f));
            var cube5 = new Asset3d(new Vector3(0.95f, 0.2f, 0.4f));


            var ellips1 = new Asset3d(new Vector3(1, 1, 1));
            var ellips2 = new Asset3d(new Vector3(1, 0.9f, 0.1f));
            var ellips3 = new Asset3d(new Vector3(1, 0.9f, 0.1f));
            var ellips4 = new Asset3d(new Vector3(0, 0, 0));
            var ellips5 = new Asset3d(new Vector3(0, 0, 0));
            var ellips6 = new Asset3d(new Vector3(1, 1, 1));
            var ellips7 = new Asset3d(new Vector3(1, 1, 1));
            var ellips8 = new Asset3d(new Vector3(1, 1, 1));
            var ellips9 = new Asset3d(new Vector3(1, 1, 1));
            var ellips10 = new Asset3d(new Vector3(1, 1, 1));
            var ellips11 = new Asset3d(new Vector3(1, 1, 1));
            var ellips12 = new Asset3d(new Vector3(1, 1, 1));
            var ellips13 = new Asset3d(new Vector3(1, 1, 1));
            var ellips14 = new Asset3d(new Vector3(1, 1, 1));
            var ellips15 = new Asset3d(new Vector3(1, 1, 1));
            var ellips16 = new Asset3d(new Vector3(1, 1, 1));
            var ellips17 = new Asset3d(new Vector3(1, 1, 1));
            var ellips18 = new Asset3d(new Vector3(1, 1, 1));
            var ellips19 = new Asset3d(new Vector3(1, 1, 1));
            var ellips20 = new Asset3d(new Vector3(1, 1, 1));
            var ellips21 = new Asset3d(new Vector3(1, 1, 1));
            var ellips22 = new Asset3d(new Vector3(1, 1, 1));
            var ellips23 = new Asset3d(new Vector3(1, 1, 1));
            var ellips24 = new Asset3d(new Vector3(1, 1, 1));
            var ellips25 = new Asset3d(new Vector3(1, 1, 1));
            var ellips26 = new Asset3d(new Vector3(1, 1, 1));
            var ellips27 = new Asset3d(new Vector3(1, 1, 1));
            var ellips28 = new Asset3d(new Vector3(1, 1, 1));
            var ellips29 = new Asset3d(new Vector3(1, 1, 1));
            var ellips30 = new Asset3d(new Vector3(1, 1, 1));
            var ellips31 = new Asset3d(new Vector3(1, 1, 1));
            var ellips32 = new Asset3d(new Vector3(1, 1, 1));
            var ellips33 = new Asset3d(new Vector3(1, 1, 1));
            var ellips34 = new Asset3d(new Vector3(1, 1, 1));
            var ellips35 = new Asset3d(new Vector3(1, 1, 1));
            var ellips36 = new Asset3d(new Vector3(1, 1, 1));
            var ellips37 = new Asset3d(new Vector3(1, 1, 1));
            var ellips38 = new Asset3d(new Vector3(1, 1, 1));
            var ellips39 = new Asset3d(new Vector3(1, 1, 1));
            var ellips40 = new Asset3d(new Vector3(1, 1, 1));
            var ellips41 = new Asset3d(new Vector3(1, 1, 1));


            var torus1 = new Asset3d(new Vector3(1f, 1f, 0));

            var Tube1 = new Asset3d(new Vector3(1, 1, 1));
            var Tube2 = new Asset3d(new Vector3(0, 0, 0));
            var Tube3 = new Asset3d(new Vector3(1, 1, 1));
            var Tube4 = new Asset3d(new Vector3(0, 0, 0));
            var Tube5 = new Asset3d(new Vector3(1, 1, 1));
            var Tube6 = new Asset3d(new Vector3(0, 0, 0));
            var Tube7 = new Asset3d(new Vector3(1, 1, 1));
            var Tube8 = new Asset3d(new Vector3(0, 0, 0));
            var Tube9 = new Asset3d(new Vector3(0, 0, 0));

            var rectangle1 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle2 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle3 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle4 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle5 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle6 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle7 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle8 = new Asset3d(new Vector3(0, 0, 0));
            var rectangle9 = new Asset3d(new Vector3(1,0,1));


            //alvin

            var alvinellips1 = new Asset3d(new Vector3(1, 1, 1));
            var alvinellips2 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips3 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips4 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips5 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips6 = new Asset3d(new Vector3(1, 1, 1));
            var alvintube1 = new Asset3d(new Vector3(0, 0, 0));
            var alvintube2 = new Asset3d(new Vector3(0, 0, 0));
            var alvintube3 = new Asset3d(new Vector3(0, 0, 0));
            var alvintube4 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips7 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips8 = new Asset3d(new Vector3(1, 1, 1));
            var alvinellips9 = new Asset3d(new Vector3(1, 1, 1));
            var alvinellips10 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips11 = new Asset3d(new Vector3(0, 0, 0));
            var alvintriangle1 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips12 = new Asset3d(new Vector3(0, 0, 0));
            var alvinellips13 = new Asset3d(new Vector3(1, 0, 0));
            var alvinellips14 = new Asset3d(new Vector3(1f, 0.6f, 1f));
            var alvinellips15 = new Asset3d(new Vector3(1f, 0.6f, 1f));
            var alvinellips16 = new Asset3d(new Vector3(0, 0, 0));

            //hans
            var cube1Hans = new Asset3d(new Vector3(1, 1, 1));
            var cube2Hans = new Asset3d(new Vector3(0.95f, 0.4f, 0.4f));
            var cube3Hans = new Asset3d(new Vector3(0.95f, 0.4f, 0.4f));

            var elipsoidHans1 = new Asset3d(new Vector3(0.95f, 0.4f, 0.4f));
            var elipsoidHans2 = new Asset3d(new Vector3(0, 0, 0));
            var elipsoidHans3 = new Asset3d(new Vector3(0, 0, 0));

            var tubeHans1 = new Asset3d(new Vector3(0.95f, 0.6f, 0.4f));
            var hidungKanan = new Asset3d(new Vector3(0, 0, 0));
            var hidungKiri = new Asset3d(new Vector3(0, 0, 0));

            var tubeHans2 = new Asset3d(new Vector3(0.95f, 0.4f, 0.4f));
            var elipsoidHans4 = new Asset3d(new Vector3(0.95f, 0.4f, 0.4f));
            var kakidepankiri = new Asset3d(new Vector3(0f, 0f, 0f));
            var kakidepankanan = new Asset3d(new Vector3(0f, 0f, 0f));
            var kakibelakangkiri = new Asset3d(new Vector3(0f, 0f, 0f));
            var kakibelakangkanan = new Asset3d(new Vector3(0f, 0f, 0f));

            //environment
            var Land = new Asset3d(new Vector3(0.5f, 0.9f, 0.5f));
            var Road = new Asset3d(new Vector3(0.1f, 0.1f, 0.1f));
            var Road2 = new Asset3d(new Vector3(0.1f, 0.1f, 0.1f));
            var Road3 = new Asset3d(new Vector3(0.1f, 0.1f, 0.1f));
            var Roadstrip = new Asset3d(new Vector3(1f, 1f, 1f));
            var Roadstrip2 = new Asset3d(new Vector3(1f, 1f, 1f));
            var Roadstrip3 = new Asset3d(new Vector3(1f, 1f, 1f));
            var Roadstrip4 = new Asset3d(new Vector3(1f, 1f, 1f));
            var Roadstrip5 = new Asset3d(new Vector3(1f, 1f, 1f));
            var Roadstrip6 = new Asset3d(new Vector3(1f, 1f, 1f));
            var parkinglot = new Asset3d(new Vector3(0.1f, 0.1f, 0.1f));
            var parkingstrip1 = new Asset3d(new Vector3(1f, 1f, 1f));

            var talidonutkiri = new Asset3d(new Vector3(0, 0, 0));
            var talidonutkanan = new Asset3d(new Vector3(0, 0, 0));

            var bambu1 = new Asset3d(new Vector3(0f, 0.5f, 0));
            var bambu2 = new Asset3d(new Vector3(0f, 0.5f, 0));
            var bambu3 = new Asset3d(new Vector3(0f, 0.5f, 0));
            var bambu4 = new Asset3d(new Vector3(0f, 0.5f, 0));
            var bambu5 = new Asset3d(new Vector3(0f, 0.5f, 0));
            var bambu6 = new Asset3d(new Vector3(0f, 0.5f, 0));

            var bambutorus1 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus2 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus3 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus4 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus5 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus6 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus7 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus8 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus9 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus10 = new Asset3d(new Vector3(0f, 0.3f, 0));
            var bambutorus11 = new Asset3d(new Vector3(0f, 0.3f, 0));
            //cloud
            var cloud1 = new Asset3d(new Vector3(1, 1, 1));
            var cloud2 = new Asset3d(new Vector3(1, 1, 1));
            var cloud3 = new Asset3d(new Vector3(1, 1, 1));
            var cloud4 = new Asset3d(new Vector3(1, 1, 1));

            var cloud5 = new Asset3d(new Vector3(1, 1, 1));
            var cloud6 = new Asset3d(new Vector3(1, 1, 1));
            var cloud7 = new Asset3d(new Vector3(1, 1, 1));
            var cloud8 = new Asset3d(new Vector3(1, 1, 1));

            var pagarhori1 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarvert = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert2 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert3 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert4 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert5 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert6 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert7 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert8 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert9 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert10 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert11 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert12 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert13 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert14 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert15 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert16 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert17 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert18 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert19 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert20 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert21 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert22 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert23 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert24 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert25 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert26 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert27 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert28 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert29 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert30 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert31 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert32 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert33 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert34 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert35 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert36 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert37 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert38 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert39 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert40 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert41 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert42 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert43 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert44 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert45 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert46 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert47 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert48 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert49 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert50 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert51 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert52 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert53 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert54 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert55 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert56 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert57 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert58 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert59 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert60 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert61 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert62 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert63 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert64 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert65 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert66 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert67 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert68 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert69 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert70 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert71 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert72 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert73 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert74 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert75 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert76 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert77 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert78 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert79 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert80 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert81 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert82 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert83 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert84 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert85 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert86 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert87 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert88 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert89 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            
            var pagarvert90 = new Asset3d(new Vector3(1f, 1f, 1));
            var pagarvert91 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert92 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert93 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert94 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert95 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert96 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert97 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert98 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert99 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert100 = new Asset3d(new Vector3(0.45f, 0.24f, 0));

            var pagarvert101 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert102 = new Asset3d(new Vector3(1f, 1f, 1));
            var pagarvert103 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert104 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert105 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert106 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert107 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert108 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert109 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert110 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert111 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert112 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert113 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert114 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert115 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert116 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert117 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert118 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert119 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert120 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert121 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert122 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert123 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert124 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert125 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert126 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert127 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert128 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert129 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert130 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert131 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert132 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert133 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert134 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert135 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert136 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert137 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert138 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert139 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert140 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert141 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert142 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert143 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert144 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert145 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert146 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert147 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert148 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert149 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert150 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert151 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert152 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert153 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert154 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert155 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert156 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert157 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert158 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert159 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert160 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert161 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert162 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert163 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert164 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert165 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert166 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert167 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert168 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert169 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert170 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert171 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert172 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert173 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert174 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert175 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert176 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert177 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert178 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert179 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert180 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert181 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert182 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert183 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert184 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert185 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert186 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert187 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert188 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert189 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert190 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert191 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert192 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert193 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert194 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert195 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert196 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert197 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert198 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert199 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert200 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert201 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert202 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert203 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert204 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert205 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert206 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert207 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert208 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert209 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert210 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert211 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert212 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert213 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert214 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert215 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert216 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert217 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert218 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert219 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert220 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert221 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert222 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert223 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert224 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert225 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert226 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert227 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert228 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert229 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert230 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert231 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert232 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert233 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert234 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert235 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert236 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert237 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert238 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert239 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert240 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert241 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert242 = new Asset3d(new Vector3(0.45f, 0.24f, 0));
            var pagarvert243 = new Asset3d(new Vector3(0.45f, 0.24f, 0));

            var pagarhori2 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori3 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori4 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori5 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori6 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori7 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori8 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori9 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori10 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori11 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori12 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori13 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori14 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori15 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori16 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori17 = new Asset3d(new Vector3(0.45f, 0.3f, 0));
            var pagarhori18 = new Asset3d(new Vector3(0.45f, 0.3f, 0));


            var tiang1 = new Asset3d(new Vector3(0, 0, 0));
            var tiang2 = new Asset3d(new Vector3(0, 0, 0));
            var tiangatas = new Asset3d(new Vector3(1, 1, 1));


            var talikiri = new Asset3d(new Vector3(1, 1, 0));
            var talikanan = new Asset3d(new Vector3(1, 1, 0));
            var ayunankayu = new Asset3d(new Vector3(0.45f, 0.24f, 0));


            LightObject.createCuboid(1f, -8.5f,4.3f, 0.5f);

            cube1.createCuboid4(2, -6f   , 15f, 1);
            cuberand.createCuboid(4.5f, -5, 25, 1);
            persegipanjang.createRectangle(4.5f, -6.5f, 25, 0.8f, 2f, 0.8f);
            persegipanjang2.createRectangle(5f, -6.5f, 25, 0.2f, 1.5f, 0.4f);
            persegipanjang3.createRectangle(4f, -6.5f, 25, 0.2f, 1.5f, 0.4f);
            persegipanjang4.createRectangle(4.25f, -7.9f, 25, 0.3f, 1.5f, 0.4f);
            persegipanjang5.createRectangle(4.75f, -7.9f, 25, 0.3f, 1.5f, 0.4f);




            cube2.createCuboid3(-0.35f, -5.55f, 15f, 1);
            cube3.createCuboid2(0.35f , -5.55f, 15f, 1); //sama dengan createBoxVertices
            ellips1.createEllipsoid(0, -6f, 15f, 1, 1.25f, 1, 100, 100);

            torus1.createTorus(-1, -1, 17, 1, 0.25f, 100, 100);

            cube4.createCuboid2(0.35f , -5.55f, 15f, 0.90f);
            cube5.createCuboid3(-0.35f, -5.55f, 15f, 0.90f);


            ellips2.createEllipsoid(0.30f  ,-5.75f, 15.875f, 0.1f, 0.2f, 0.1f, 100, 100);
            ellips3.createEllipsoid(-0.30f ,-5.75f, 15.875f, 0.1f, 0.2f, 0.1f, 100, 100);
            ellips4.createEllipsoid(-0.30f ,-5.75f, 15.9f, 0.08f, 0.15f, 0.08f, 100, 100);
            ellips5.createEllipsoid(0.30f  ,-5.75f, 15.9f, 0.08f, 0.15f, 0.08f, 100, 100);
            ellips6.createEllipsoid(0      ,-6.90f, 14.8f, 0.90f, 1f, 0.9f, 100, 100);
            ellips7.createEllipsoid(0      ,-7.0f , 14.6f, 0.9f, 1f, 0.9f, 100, 100);
            ellips8.createEllipsoid(0.2f   ,-7.0f , 14.4f, 0.9f, 1f, 0.9f, 100, 100);
            ellips9.createEllipsoid(-0.2f  ,-7.0f , 14.4f, 0.9f, 1f, 0.9f, 100, 100);
            ellips10.createEllipsoid(0.2f  ,-7.0f , 14.2f, 0.9f, 1f, 0.9f, 100, 100);
            ellips11.createEllipsoid(-0.2f ,-7.0f , 14.2f, 0.9f, 1f, 0.9f, 100, 100);
            ellips12.createEllipsoid(0.2f  ,-7.0f , 14f, 0.9f, 1f, 0.9f, 100, 100);
            ellips13.createEllipsoid(-0.2f ,-7.0f , 14f, 0.9f, 1f, 0.9f, 100, 100);
            ellips14.createEllipsoid(0.2f  ,-7.0f , 13.8f, 0.9f, 1f, 0.9f, 100, 100);
            ellips15.createEllipsoid(-0.2f ,-7.0f , 13.8f, 0.9f, 1f, 0.9f, 100, 100);
            ellips16.createEllipsoid(0.2f  ,-7.0f , 13.6f, 0.9f, 1f, 0.9f, 100, 100);
            ellips17.createEllipsoid(-0.2f ,-7.0f , 13.6f, 0.9f, 1f, 0.9f, 100, 100);
            ellips18.createEllipsoid(0.2f  ,-7f   , 13.4f, 0.9f, 1f, 0.9f, 100, 100);
            ellips19.createEllipsoid(-0.2f ,-7f   , 13.4f, 0.9f, 1f, 0.9f, 100, 100);
            ellips20.createEllipsoid(0.2f  ,-7f   , 13.2f, 0.9f, 1f, 0.9f, 100, 100);
            ellips21.createEllipsoid(-0.2f ,-7f   , 13.2f, 0.9f, 1f, 0.9f, 100, 100);
            ellips22.createEllipsoid(0.2f  ,-7f   , 13f, 0.9f, 1f, 0.9f, 100, 100);
            ellips23.createEllipsoid(-0.2f ,-7f   , 13f, 0.9f, 1f, 0.9f, 100, 100);
            ellips24.createEllipsoid(0.2f  ,-6.8f , 12.8f, 0.9f, 1f, 0.9f, 100, 100);
            ellips25.createEllipsoid(-0.2f ,-6.8f , 12.8f, 0.9f, 1f, 0.9f, 100, 100);
            ellips26.createEllipsoid(0.3f  ,-7.1f , 14.4f, 0.9f, 1f, 0.9f, 100, 100);
            ellips27.createEllipsoid(-0.3f ,-7.1f , 14.4f, 0.9f, 1f, 0.9f, 100, 100);
            ellips28.createEllipsoid(0.3f  ,-7.0f , 12.8f, 0.9f, 1f, 0.9f, 100, 100);
            ellips29.createEllipsoid(-0.3f ,-7.0f , 12.8f, 0.9f, 1f, 0.9f, 100, 100);
            ellips30.createEllipsoid(0.3f  ,-7.6f , 14.4f, 0.6f, 0.7f, 0.6f, 100, 100);
            ellips31.createEllipsoid(-0.3f ,-7.6f , 14.4f, 0.6f, 0.7f, 0.6f, 100, 100);
 
            //segitiga in i
            //ellips32.createTube(2f, 2f, 2f, 1f,  1f, 1f, 2, 2);
            Tube1.createTube(-0.3f, -8.6f, 14.4f,  0.3f, 0.6f, 0.3f, 100, 3);
            Tube2.createTube(-0.3f, -8.6f, 14.55f, 0.3f, 0.2f, 0.3f, 100, 3);
            Tube3.createTube(0.3f, -8.6f, 14.4f, 0.3f, 0.6f, 0.3f, 100, 3);
            Tube4.createTube(0.3f, -8.6f, 14.5f, 0.3f, 0.2f, 0.3f, 100, 3);
            Tube5.createTube(-0.3f, -8.5f, 12.65f, 0.3f, 0.6f, 0.3f, 100, 3);
            Tube6.createTube(-0.3f, -8.5f, 12.8f, 0.3f, 0.2f, 0.3f, 100, 3);
            Tube7.createTube(0.3f, -8.5f, 12.655f, 0.3f, 0.6f, 0.3f, 100, 3);
            Tube8.createTube(0.3f, -8.5f, 12.8f, 0.3f, 0.2f, 0.3f, 100, 3);
            Tube9.createTube(0, -6.25f, 16f, 0.1f, 0.2f, 0.1f, 2, 2);

            rectangle1.createRectangle(0.8f, -5.95f, 15.8f, 0.4f, 0.01f, 0.01f);
            rectangle2.createRectangle(0.8f, -6.1f, 15.8f, 0.4f, 0.01f, 0.01f);
            rectangle3.createRectangle(0.8f, -6.25f, 15.8f, 0.4f, 0.01f, 0.01f);
            rectangle4.createRectangle(-0.8f, -6.25f, 15.8f, 0.4f, 0.01f, 0.01f);
            rectangle5.createRectangle(-0.8f, -5.95f, 15.8f, 0.4f, 0.01f, 0.01f);
            rectangle6.createRectangle(-0.8f, -6.1f, 15.8f, 0.4f, 0.01f, 0.01f);
            rectangle7.createRectangle(-0f, -7.5f, 11.9f, 0.1f, 0.01f, 0.05f);
            rectangle8.createRectangle(-0f, -7.9f, 11.8f, 0.1f, 0.01f, 0.05f);
            rectangle9.createRectangle(-0f, -7.95f, 11.85f, 0.1f, 0.01f, 0.05f);

            //alvin create

            alvinellips1.createEllipsoid(1f, -7f, 6f, 1f, 1.5f, 1f, 100, 100);//kepala -3 +0.9
            alvinellips2.createEllipsoid(0.5f, -5.4f, 6f, 0.25f, 0.5f, 0.25f, 100, 100);//telinga kiri
            alvinellips3.createEllipsoid(1.5f, -5.4f, 6f, 0.25f, 0.5f, 0.25f, 100, 100);//telinga kanan
            alvinellips4.createEllipsoid(0.7f, -6f, 6.5f, 0.25f, 0.3f, 0.3f, 100, 100);//mata kiri
            alvinellips5.createEllipsoid(1.2f, -6f, 6.5f, 0.25f, 0.3f, 0.3f, 100, 100);//mata kanan
            alvinellips6.createEllipsoid(1f, -7f, 3f, 1.5f, 2f, 3f, 100, 100);//badan
            alvintube1.createTube(0.3f, -9.2f, 4.7f, 0.5f, 1.8f, 1f, 100, 3);//kaki kiri depan
            alvintube2.createTube(1.6f, -9.2f, 4.7f, 0.5f, 1.8f, 1f, 100, 3);//kaki kanan depan
            alvintube3.createTube(1.6f, -9.2f, 1.5f, 0.5f, 1.8f, 1f, 100, 3);//kaki kanan belakang
            alvintube4.createTube(0.3f, -9.2f, 1.5f, 0.5f, 1.8f, 1f, 100, 3);//kaki kiri belakang
            alvinellips7.createEllipsoid(1f, -6f, 0.5f, 0.25f, 0.5f, 0.25f, 100, 100);//buntut

            alvinellips8.createEllipsoid(0.7f, -5.9f, 6.7f, 0.1f, 0.15f, 0.1f, 100, 100);//mata putih kiri
            alvinellips9.createEllipsoid(1.2f, -5.9f, 6.7f, 0.1f, 0.15f, 0.1f, 100, 100);//mata putih kanan
            alvinellips10.createEllipsoid(1.2f, -5.85f, 6.8f, 0.05f, 0.05f, 0.01f, 100, 100);//pupil kanan
            alvinellips11.createEllipsoid(0.7f, -5.85f, 6.8f, 0.05f, 0.05f, 0.01f, 100, 100);//pupil kiri
            alvintriangle1.createEllipsoid(0.95f, -6.3f, 7f, 0.05f, -0.05f, 0.05f, 100, 100);//hidung
            alvinellips12.createEllipsoid(0.95f, -7f, 7f, 0.2f, 0.2f, 0.1f, 100, 100);//mulut
            alvinellips13.createEllipsoid(0.975f, -7.025f, 7.05f, 0.15f, 0.1f, 0.1f, 100, 100);//lidah
            alvinellips14.createEllipsoid(1.38f, -6.5f, 6.7f, 0.22f, 0.25f, 0.25f, 100, 100);//pipi kanan
            alvinellips15.createEllipsoid(0.57f, -6.5f, 6.7f, 0.22f, 0.25f, 0.25f, 100, 100);//pipi kiri
            alvinellips16.createEllipsoid(1f, -7f, 4.3f, 1.5f, 2f, 2f, 100, 100);//badanbelang



            //environment

            Land.createRectangle(3.7f, -11.5f, 6.9f, 250f, 5f, 250f);//rumput/tanah
            Road.createRectangle(3.7f, -8.8f, 2.2f, 6f, 0.05f, 34.5f);//rumput/tanah
            Road2.createRectangle(30.7f, -8.8f, -5.2f, 6f, 0.05f, 52.5f);
            Road3.createRectangle(20.7f, -8.8f, -32.5f, 26f, 0.05f, 5f);
            Roadstrip.createRectangle(30.7f, -8.7f, 7f, 0.5f, 0.05f, 5f);//rumput/tanah
            Roadstrip2.createRectangle(30.7f, -8.7f, 15f, 0.5f, 0.05f, 5f);//rumput/tanah
            Roadstrip3.createRectangle(30.7f, -8.7f, -1f, 0.5f, 0.05f, 5f);//rumput/tanah
            Roadstrip4.createRectangle(30.7f, -8.7f, -9f, 0.5f, 0.05f, 5f);//rumput/tanah
            Roadstrip5.createRectangle(30.7f, -8.7f, -17f, 0.5f, 0.05f, 5f);//rumput/tanah
            Roadstrip6.createRectangle(30.7f, -8.7f, -25f, 0.5f, 0.05f, 5f);//rumput/tanah
            parkinglot.createRectangle(5.7f, -8.8f, -45f, 20f, 0.05f, 30f);
            parkingstrip1.createRectangle(10f, -8.7f, -15f, 5f, 00.5f, 0.5f);//rumput/tanah

            tiang1.createRectangle(12f, -5f, -3f, 0.8f, 15f, 0.8f);
            tiang2.createRectangle(12f, -5f, 3f, 0.8f, 15f, 0.8f);
            tiangatas.createRectangle(12f, 2f, 0f, 0.5f, 0.5f, 6.5f);

            talikiri.createTube(12f, 2f, -1f, 0.05f, -8f, 0.05f, 100, 3);
            talikanan.createTube(12f, 2f, 1f, 0.05f, -8f, 0.05f, 100, 3);

            cloud1.createEllipsoid(5f, 10f, -3f, 2f, 2f, 2f, 100, 100);
            cloud2.createEllipsoid(3.5f, 10f, -3f, 2f, 2f, 2f, 100, 100);
            cloud3.createEllipsoid(2f, 10f, -3f, 2f, 2f, 2f, 100, 100);
            cloud4.createEllipsoid(3.5f, 12f, -3f, 2f, 2f, 2f, 100, 100);

            cloud5.createEllipsoid(-2.5f, 5f, -3f, 2f, 2f, 2f, 100, 100);
            cloud6.createEllipsoid(-4f, 5f, -3f, 2f, 2f, 2f, 100, 100);
            cloud7.createEllipsoid(-6.5f, 5f, -3f, 2f, 2f, 2f, 100, 100);
            cloud8.createEllipsoid(-4f, 7f, -3f, 2f, 2f, 2f, 100, 100);

            bambu1.createTube(-6.9f, -9f, 1f, 0.2f, 10f, 0.2f, 100, 3);
            bambu2.createTube(-7.6f, -9f, 1.5f, 0.2f, 7f, 0.2f, 100, 3);
            bambu3.createTube(-7.4f, -9f, 2f, 0.2f, 8f, 0.2f, 100, 3);
            bambu4.createTube(-7f, -9f, 4f, 0.2f, 5f, 0.2f, 100, 3);
            bambu5.createTube(-7.1f, -9f, 4.5f, 0.2f, 4f, 0.2f, 100, 3);
            bambu6.createTube(-7.3f, -9f, 5f, 0.2f, 2f, 0.2f, 100, 3);

            bambutorus1.createTorus(-6.9f, -8f, 1f, 0.1f, 0.1f, 100, 100);
            bambutorus2.createTorus(-6.9f, -5f, 1f, 0.1f, 0.1f, 100, 100);
            bambutorus3.createTorus(-6.9f, -2f, 1f, 0.1f, 0.1f, 100, 100);
            bambutorus4.createTorus(-7.6f, -4f, 1.5f, 0.1f, 0.1f, 100, 100);
            bambutorus5.createTorus(-7.6f, -7f, 1.5f, 0.1f, 0.1f, 100, 100);
            bambutorus6.createTorus(-7.4f, -3f, 2f, 0.1f, 0.1f, 100, 100);
            bambutorus7.createTorus(-7.4f, -6f, 2f, 0.1f, 0.1f, 100, 100);
            bambutorus8.createTorus(-7f, -5f, 4f, 0.1f, 0.1f, 100, 100);
            bambutorus9.createTorus(-7.1f, -7f, 4.5f, 0.1f, 0.1f, 100, 100);
            bambutorus10.createTorus(-7.3f, -8f, 5f, 0.1f, 0.1f, 100, 100);
            bambutorus11.createTorus(-7f, -8f, 4f, 0.1f, 0.1f, 100, 100);



            ayunankayu.createRectangle(12f, -6f, 0f, 1f, 0.5f, 3f);
            talidonutkiri.createTorus(12f, 1.7f, -1f, 0.05f, 0.05f, 100, 100);
            talidonutkanan.createTorus(12f, 1.7f, 1f, 0.05f, 0.05f, 100, 100);

            pagarvert.createRectangle(16, -7.5f, -2.1f, 0.05f, 3f, 0.5f);
            pagarvert2.createRectangle(16f, -7.5f, -1.4f, 0.05f, 3f, 0.5f);
            pagarvert3.createRectangle(16f, -7.5f, -0.7f, 0.05f, 3f, 0.5f);
            pagarvert4.createRectangle(16f, -7.5f, -0f, 0.05f, 3f, 0.5f);
            pagarvert5.createRectangle(16f, -7.5f, -3.5f, 0.05f, 3f, 0.5f);
            pagarvert6.createRectangle(16f, -7.5f, -2.8f, 0.05f, 3f, 0.5f);
            pagarvert7.createRectangle(16f, -7.5f, -4.2f, 0.05f, 3f, 0.5f);
            pagarvert8.createRectangle(16f, -7.5f, -4.9f, 0.05f, 3f, 0.5f);



            pagarvert9.createRectangle(15.7f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert10.createRectangle(15f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert11.createRectangle(14.3f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert12.createRectangle(13.6f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert13.createRectangle(12.9f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert14.createRectangle(12.2f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert15.createRectangle(11.5f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert16.createRectangle(10.8f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert17.createRectangle(10.1f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert18.createRectangle(9.4f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert19.createRectangle(8.7f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert20.createRectangle(8f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert21.createRectangle(7.3f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert22.createRectangle(6.6f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert23.createRectangle(5.9f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert24.createRectangle(5.2f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert25.createRectangle(4.5f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert26.createRectangle(3.8f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert27.createRectangle(3.1f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert28.createRectangle(2.4f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert29.createRectangle(1.7f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert30.createRectangle(1f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert31.createRectangle(0.3f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert32.createRectangle(-0.4f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert33.createRectangle(-1.1f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert34.createRectangle(-1.8f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert35.createRectangle(-2.5f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert36.createRectangle(-3.2f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert37.createRectangle(-3.9f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert38.createRectangle(-4.6f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert39.createRectangle(-5.3f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert40.createRectangle(-6f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert41.createRectangle(-6.7f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert42.createRectangle(-7.4f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);
            pagarvert43.createRectangle(-8.1f, -7.5f, -15.15f, 0.5f, 3f, 0.05f);

            pagarvert44.createRectangle(-8.4f, -7.5f, -4.9f, 0.05f, 3f, 0.5f);
            pagarvert45.createRectangle(-8.4f, -7.5f, -4.2f, 0.05f, 3f, 0.5f);
            pagarvert46.createRectangle(-8.4f, -7.5f, -3.5f, 0.05f, 3f, 0.5f);
            pagarvert47.createRectangle(-8.4f, -7.5f, -2.8f, 0.05f, 3f, 0.5f);
            pagarvert48.createRectangle(-8.4f, -7.5f, -2.1f, 0.05f, 3f, 0.5f);
            pagarvert49.createRectangle(-8.4f, -7.5f, -1.4f, 0.05f, 3f, 0.5f);
            pagarvert50.createRectangle(-8.4f, -7.5f, -0.7f, 0.05f, 3f, 0.5f);
            pagarvert51.createRectangle(-8.4f, -7.5f, 0f, 0.05f, 3f, 0.5f);
            pagarvert52.createRectangle(-8.4f, -7.5f, 0.7f, 0.05f, 3f, 0.5f);
            pagarvert53.createRectangle(-8.4f, -7.5f, 1.4f, 0.05f, 3f, 0.5f);
            pagarvert54.createRectangle(-8.4f, -7.5f, 2.1f, 0.05f, 3f, 0.5f);
            pagarvert55.createRectangle(-8.4f, -7.5f, 2.8f, 0.05f, 3f, 0.5f);
            pagarvert56.createRectangle(-8.4f, -7.5f, 3.5f, 0.05f, 3f, 0.5f);
            pagarvert57.createRectangle(-8.4f, -7.5f, 4.2f, 0.05f, 3f, 0.5f);
            pagarvert58.createRectangle(-8.4f, -7.5f, 4.9f, 0.05f, 3f, 0.5f);
            pagarvert59.createRectangle(-8.4f, -7.5f, 5.6f, 0.05f, 3f, 0.5f);
            pagarvert60.createRectangle(-8.4f, -7.5f, 6.3f, 0.05f, 3f, 0.5f);
            pagarvert61.createRectangle(-8.4f, -7.5f, 7f, 0.05f, 3f, 0.5f);
            pagarvert62.createRectangle(-8.4f, -7.5f, 7.7f, 0.05f, 3f, 0.5f);
            pagarvert63.createRectangle(-8.4f, -7.5f, 8.4f, 0.05f, 3f, 0.5f);
            pagarvert64.createRectangle(-8.4f, -7.5f, 9.1f, 0.05f, 3f, 0.5f);
            pagarvert65.createRectangle(-8.4f, -7.5f, 9.8f, 0.05f, 3f, 0.5f);
            pagarvert66.createRectangle(-8.4f, -7.5f, 10.5f, 0.05f, 3f, 0.5f);
            pagarvert67.createRectangle(-8.4f, -7.5f, 11.2f, 0.05f, 3f, 0.5f);
            pagarvert68.createRectangle(-8.4f, -7.5f, 11.9f, 0.05f, 3f, 0.5f);
            pagarvert69.createRectangle(-8.4f, -7.5f, 12.6f, 0.05f, 3f, 0.5f);
            pagarvert70.createRectangle(-8.4f, -7.5f, 13.3f, 0.05f, 3f, 0.5f);
            pagarvert71.createRectangle(-8.4f, -7.5f, 14f, 0.05f, 3f, 0.5f);
            pagarvert72.createRectangle(-8.4f, -7.5f, 14.7f, 0.05f, 3f, 0.5f);
            pagarvert73.createRectangle(-8.4f, -7.5f, 15.4f, 0.05f, 3f, 0.5f);
            pagarvert74.createRectangle(-8.4f, -7.5f, 16.1f, 0.05f, 3f, 0.5f);
            pagarvert75.createRectangle(-8.4f, -7.5f, 16.8f, 0.05f, 3f, 0.5f);
            pagarvert76.createRectangle(-8.4f, -7.5f, 17.5f, 0.05f, 3f, 0.5f);
            pagarvert77.createRectangle(-8.4f, -7.5f, 18.2f, 0.05f, 3f, 0.5f);
            pagarvert78.createRectangle(-8.4f, -7.5f, 18.9f, 0.05f, 3f, 0.5f);
            pagarvert79.createRectangle(-8.1f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert80.createRectangle(-7.4f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert81.createRectangle(-6.7f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert82.createRectangle(-6f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert83.createRectangle(-5.3f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert84.createRectangle(-4.6f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert85.createRectangle(-3.9f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert86.createRectangle(-3.2f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert87.createRectangle(-2.5f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert88.createRectangle(-1.8f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert89.createRectangle(-1.1f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert90.createRectangle(-0.4f, -7f, 19.2f, 0.5f, 12f, 0.3f);

            //pagar pintu masuk
            pagarvert91.createRectangle(0.3f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert92.createRectangle(1f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert93.createRectangle(1.7f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert94.createRectangle(2.4f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert95.createRectangle(3.1f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert96.createRectangle(3.8f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert97.createRectangle(4.5f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert98.createRectangle(5.2f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert99.createRectangle(5.9f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert100.createRectangle(6.6f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);
            pagarvert195.createRectangle(7.3f, -7.5f, 19.8f, 0.5f, 3f, 0.05f);


            pagarvert101.createRectangle(3.8f, 0.5f, 19.2f, 9f, 3f, 0.7f);
            pagarvert102.createRectangle(8f, -7f, 19.2f, 0.5f, 12f, 0.3f);
            pagarvert103.createRectangle(8.7f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert104.createRectangle(9.4f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert105.createRectangle(10.1f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert106.createRectangle(10.8f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert107.createRectangle(11.5f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert108.createRectangle(12.2f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert109.createRectangle(12.9f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert110.createRectangle(13.6f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert111.createRectangle(14.3f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert112.createRectangle(15f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert113.createRectangle(15.7f, -7.5f, 19.2f, 0.5f, 3f, 0.05f);
            pagarvert114.createRectangle(16f, -7.5f, 0.7f, 0.05f, 3f, 0.5f);
            pagarvert115.createRectangle(16f, -7.5f, 1.4f, 0.05f, 3f, 0.5f);
            pagarvert116.createRectangle(16f, -7.5f, 2.1f, 0.05f, 3f, 0.5f);
            pagarvert117.createRectangle(16f, -7.5f, 2.8f, 0.05f, 3f, 0.5f);
            pagarvert118.createRectangle(16f, -7.5f, 3.5f, 0.05f, 3f, 0.5f);
            pagarvert119.createRectangle(16f, -7.5f, 4.2f, 0.05f, 3f, 0.5f);
            pagarvert120.createRectangle(16f, -7.5f, 4.9f, 0.05f, 3f, 0.5f);
            pagarvert121.createRectangle(16f, -7.5f, 5.6f, 0.05f, 3f, 0.5f);
            pagarvert122.createRectangle(16f, -7.5f, 6.3f, 0.05f, 3f, 0.5f);
            pagarvert123.createRectangle(16f, -7.5f, 7f, 0.05f, 3f, 0.5f);
            pagarvert124.createRectangle(16f, -7.5f, 7.7f, 0.05f, 3f, 0.5f);
            pagarvert125.createRectangle(16f, -7.5f, 8.4f, 0.05f, 3f, 0.5f);
            pagarvert126.createRectangle(16f, -7.5f, 9.1f, 0.05f, 3f, 0.5f);
            pagarvert127.createRectangle(16f, -7.5f, 9.8f, 0.05f, 3f, 0.5f);
            pagarvert128.createRectangle(16f, -7.5f, 10.5f, 0.05f, 3f, 0.5f);
            pagarvert129.createRectangle(16f, -7.5f, 11.2f, 0.05f, 3f, 0.5f);
            pagarvert130.createRectangle(16f, -7.5f, 11.9f, 0.05f, 3f, 0.5f);
            pagarvert131.createRectangle(16f, -7.5f, 12.6f, 0.05f, 3f, 0.5f);
            pagarvert132.createRectangle(16f, -7.5f, 13.3f, 0.05f, 3f, 0.5f);
            pagarvert133.createRectangle(16f, -7.5f, 14f, 0.05f, 3f, 0.5f);
            pagarvert134.createRectangle(16f, -7.5f, 14.7f, 0.05f, 3f, 0.5f);
            pagarvert135.createRectangle(16f, -7.5f, 15.4f, 0.05f, 3f, 0.5f);
            pagarvert136.createRectangle(16f, -7.5f, 16.1f, 0.05f, 3f, 0.5f);
            pagarvert137.createRectangle(16f, -7.5f, 16.8f, 0.05f, 3f, 0.5f);
            pagarvert138.createRectangle(16f, -7.5f, 17.5f, 0.05f, 3f, 0.5f);
            pagarvert139.createRectangle(16f, -7.5f, 18.2f, 0.05f, 3f, 0.5f);
            pagarvert140.createRectangle(16f, -7.5f, 18.9f, 0.05f, 3f, 0.5f);

            pagarvert141.createRectangle(-8.4f, -7.5f, 18.9f, 0.05f, 3f, 0.5f);
            pagarvert142.createRectangle(-8.1f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert143.createRectangle(-7.4f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert144.createRectangle(-6.7f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert145.createRectangle(-6f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert146.createRectangle(-5.3f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert147.createRectangle(-4.6f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert148.createRectangle(-3.9f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert149.createRectangle(-3.2f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert150.createRectangle(-2.5f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert151.createRectangle(-1.8f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert152.createRectangle(-1.1f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);
            pagarvert153.createRectangle(-0.4f, -7.5f, 10.2f, 0.5f, 3f, 0.05f);

            pagarvert154.createRectangle(16f, -7.5f, -5.6f, 0.05f, 3f, 0.5f);
            pagarvert155.createRectangle(16f, -7.5f, -6.3f, 0.05f, 3f, 0.5f);
            pagarvert156.createRectangle(16f, -7.5f, -7f, 0.05f, 3f, 0.5f);
            pagarvert157.createRectangle(16f, -7.5f, -7.7f, 0.05f, 3f, 0.5f);
            pagarvert158.createRectangle(16f, -7.5f, -8.4f, 0.05f, 3f, 0.5f);
            pagarvert159.createRectangle(16f, -7.5f, -9.1f, 0.05f, 3f, 0.5f);
            pagarvert160.createRectangle(16f, -7.5f, -9.8f, 0.05f, 3f, 0.5f);
            pagarvert161.createRectangle(16f, -7.5f, -10.5f, 0.05f, 3f, 0.5f);
            pagarvert162.createRectangle(16f, -7.5f, -11.2f, 0.05f, 3f, 0.5f);
            pagarvert163.createRectangle(16f, -7.5f, -11.9f, 0.05f, 3f, 0.5f);
            pagarvert164.createRectangle(16f, -7.5f, -12.6f, 0.05f, 3f, 0.5f);
            pagarvert165.createRectangle(16f, -7.5f, -13.3f, 0.05f, 3f, 0.5f);
            pagarvert166.createRectangle(16f, -7.5f, -14f, 0.05f, 3f, 0.5f);
            pagarvert167.createRectangle(16f, -7.5f, -14.7f, 0.05f, 3f, 0.5f);

            pagarvert168.createRectangle(-8.4f, -7.5f, -5.6f, 0.05f, 3f, 0.5f);
            pagarvert169.createRectangle(-8.4f, -7.5f, -6.3f, 0.05f, 3f, 0.5f);
            pagarvert170.createRectangle(-8.4f, -7.5f, -7f, 0.05f, 3f, 0.5f);
            pagarvert171.createRectangle(-8.4f, -7.5f, -7.7f, 0.05f, 3f, 0.5f);
            pagarvert172.createRectangle(-8.4f, -7.5f, -8.4f, 0.05f, 3f, 0.5f);
            pagarvert173.createRectangle(-8.4f, -7.5f, -9.1f, 0.05f, 3f, 0.5f);
            pagarvert174.createRectangle(-8.4f, -7.5f, -9.8f, 0.05f, 3f, 0.5f);
            pagarvert175.createRectangle(-8.4f, -7.5f, -10.5f, 0.05f, 3f, 0.5f);
            pagarvert176.createRectangle(-8.4f, -7.5f, -11.2f, 0.05f, 3f, 0.5f);
            pagarvert177.createRectangle(-8.4f, -7.5f, -11.9f, 0.05f, 3f, 0.5f);
            pagarvert178.createRectangle(-8.4f, -7.5f, -12.6f, 0.05f, 3f, 0.5f);
            pagarvert179.createRectangle(-8.4f, -7.5f, -13.3f, 0.05f, 3f, 0.5f);
            pagarvert180.createRectangle(-8.4f, -7.5f, -14f, 0.05f, 3f, 0.5f);
            pagarvert181.createRectangle(-8.4f, -7.5f, -14.7f, 0.05f, 3f, 0.5f);

            //pagarvert182.createRectangle(-8.8f, -7.5f, 3.9f, 0.05f, 3f, 0.5f);
            pagarvert183.createRectangle(-8.1f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert184.createRectangle(-7.4f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert185.createRectangle(-6.7f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert186.createRectangle(-6f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert187.createRectangle(-5.3f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert188.createRectangle(-4.6f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert189.createRectangle(-3.9f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert190.createRectangle(-3.2f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert191.createRectangle(-2.5f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert192.createRectangle(-1.8f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert193.createRectangle(-1.1f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);
            pagarvert194.createRectangle(-0.4f, -7.5f, -3.2f, 0.5f, 3f, 0.05f);

            //buat pagar kandang
            pagarvert196.createRectangle(-0.4f, -7.5f, 18.5f, 0.05f, 3f, 0.5f);
            pagarvert197.createRectangle(-0.4f, -7.5f, 17.8f, 0.05f, 3f, 0.5f);
            pagarvert198.createRectangle(-0.4f, -7.5f, 17.1f, 0.05f, 3f, 0.5f);
            pagarvert199.createRectangle(-0.4f, -7.5f, 16.4f, 0.05f, 3f, 0.5f);
            pagarvert200.createRectangle(-0.4f, -7.5f, 15.7f, 0.05f, 3f, 0.5f);
            pagarvert201.createRectangle(-0.4f, -7.5f, 15f, 0.05f, 3f, 0.5f);
            
            //pintu pagar kandang
            pagarvert202.createRectangle(-0.2f, -7.5f, 14.3f, 0.05f, 3f, 0.5f);
            pagarvert203.createRectangle(-0.2f, -7.5f, 13.6f, 0.05f, 3f, 0.5f);
            pagarvert204.createRectangle(-0.2f, -7.5f, 12.9f, 0.05f, 3f, 0.5f);
            pagarvert205.createRectangle(-0.2f, -7.5f, 12.2f, 0.05f, 3f, 0.5f);
            pagarvert206.createRectangle(-0.2f, -7.5f, 11.5f, 0.05f, 3f, 0.5f);
            pagarvert207.createRectangle(-0.2f, -7.5f, 10.8f, 0.05f, 3f, 0.5f);

            //pagar kandang tengah
            pagarvert208.createRectangle(-0.4f, -7.5f, 9.9f, 0.05f, 3f, 0.5f);
            pagarvert209.createRectangle(-0.4f, -7.5f, 9.2f, 0.05f, 3f, 0.5f);
            pagarvert210.createRectangle(-0.4f, -7.5f, 8.5f, 0.05f, 3f, 0.5f);
            pagarvert211.createRectangle(-0.4f, -7.5f, 7.8f, 0.05f, 3f, 0.5f);
            pagarvert212.createRectangle(-0.4f, -7.5f, 7.1f, 0.05f, 3f, 0.5f);
            pagarvert213.createRectangle(-0.4f, -7.5f, 6.4f, 0.05f, 3f, 0.5f);
            pagarvert214.createRectangle(-0.4f, -7.5f, 5.7f, 0.05f, 3f, 0.5f);
            pagarvert215.createRectangle(-0.4f, -7.5f, 5f, 0.05f, 3f, 0.5f);
            pagarvert216.createRectangle(-0.4f, -7.5f, 4.3f, 0.05f, 3f, 0.5f);
            pagarvert217.createRectangle(-0.4f, -7.5f, 3.6f, 0.05f, 3f, 0.5f);


            //pintu pagar kandang tengah
            pagarvert218.createRectangle(-0.2f, -7.5f, 2.9f, 0.05f, 3f, 0.5f);
            pagarvert219.createRectangle(-0.2f, -7.5f, 2.2f, 0.05f, 3f, 0.5f);
            pagarvert220.createRectangle(-0.2f, -7.5f, 1.5f, 0.05f, 3f, 0.5f);
            pagarvert221.createRectangle(-0.2f, -7.5f, 0.8f, 0.05f, 3f, 0.5f);
            pagarvert222.createRectangle(-0.2f, -7.5f, 0.1f, 0.05f, 3f, 0.5f);
            pagarvert223.createRectangle(-0.2f, -7.5f, -0.6f, 0.05f, 3f, 0.5f);
            pagarvert224.createRectangle(-0.2f, -7.5f, -1.3f, 0.05f, 3f, 0.5f);
            pagarvert225.createRectangle(-0.2f, -7.5f, -2f, 0.05f, 3f, 0.5f);
            pagarvert226.createRectangle(-0.2f, -7.5f, -2.7f, 0.05f, 3f, 0.5f);

            //pagar kandang paling belakang
            pagarvert227.createRectangle(-0.4f, -7.5f, -3.6f, 0.05f, 3f, 0.5f);
            pagarvert228.createRectangle(-0.4f, -7.5f, -4.3f, 0.05f, 3f, 0.5f);
            pagarvert229.createRectangle(-0.4f, -7.5f, -5f, 0.05f, 3f, 0.5f);
            pagarvert230.createRectangle(-0.4f, -7.5f, -5.7f, 0.05f, 3f, 0.5f);
            pagarvert231.createRectangle(-0.4f, -7.5f, -6.4f, 0.05f, 3f, 0.5f);
            pagarvert232.createRectangle(-0.4f, -7.5f, -7.1f, 0.05f, 3f, 0.5f);
            pagarvert233.createRectangle(-0.4f, -7.5f, -7.8f, 0.05f, 3f, 0.5f);
            pagarvert234.createRectangle(-0.4f, -7.5f, -8.5f, 0.05f, 3f, 0.5f);
            pagarvert235.createRectangle(-0.4f, -7.5f, -9.2f, 0.05f, 3f, 0.5f);

            pagarvert236.createRectangle(-0.2f, -7.5f, -9.9f, 0.05f, 3f, 0.5f);
            pagarvert237.createRectangle(-0.2f, -7.5f, -10.6f, 0.05f, 3f, 0.5f);
            pagarvert238.createRectangle(-0.2f, -7.5f, -11.3f, 0.05f, 3f, 0.5f);
            pagarvert239.createRectangle(-0.2f, -7.5f, -12f, 0.05f, 3f, 0.5f);
            pagarvert240.createRectangle(-0.2f, -7.5f, -12.7f, 0.05f, 3f, 0.5f);
            pagarvert241.createRectangle(-0.2f, -7.5f, -13.4f, 0.05f, 3f, 0.5f);
            pagarvert242.createRectangle(-0.2f, -7.5f, -14.1f, 0.05f, 3f, 0.5f);
            pagarvert243.createRectangle(-0.2f, -7.5f, -14.8f, 0.05f, 3f, 0.5f);




            //pagar horizontal
            pagarhori1.createRectangle(16f, -6.8f, 2f, 0.1f, 0.5f, 34.3f);
            pagarhori2.createRectangle(3.8f, -6.8f, -15.15f, 24.5f, 0.5f, 0.1f);
            pagarhori3.createRectangle(-8.4f, -6.8f, 2f, 0.1f, 0.5f, 34.5f);
            pagarhori4.createRectangle(-4.5f, -6.8f, 19.2f, 7.6f, 0.5f, 0.1f);
            pagarhori5.createRectangle(12.2f, -6.8f, 19.2f, 7.6f, 0.5f, 0.1f);
            pagarhori6.createRectangle(-4.1f, -6.8f, 10.2f, 8.5f, 0.5f, 0.1f);
            pagarhori7.createRectangle(-4.1f, -6.8f, -3.2f, 8.5f, 0.5f, 0.1f);
            pagarhori8.createRectangle(1.75f, -6.8f, 19.8f, 3.6f, 0.5f, 0.1f);
            pagarhori9.createRectangle(5.9f, -6.8f, 19.8f, 3.6f, 0.5f, 0.1f);

            //pagar hori untuk pintu kandang pertama
            pagarhori10.createRectangle(-0.2f, -6.8f, 12.55f, 0.1f, 0.5f, 4f);
            //pagar horizontal pintu kandang tengah
            pagarhori11.createRectangle(-0.2f, -6.8f, 0.2f, 0.1f, 0.5f, 6.4f);
            //pagar hori pintu kandang plg belakang
            pagarhori12.createRectangle(-0.2f, -6.8f, -12.3f, 0.1f, 0.5f, 5.6f);




            //pagarhori9.createRectangle(-4.1f, -6.8f, -3.2f, 8.5f, 0.5f, 0.1f);
            //alvincuboid1.createCuboid(4f, -15.5f, -1.9f, 12f);//rumput/tanah


            //hans
            cube2Hans.createCuboid3(-4.55f, -7.05f, 0, 1); //sama dengan createBoxVertices
            cube3Hans.createCuboid2(-3.85f, -7.05f, 0, 1); //sama dengan createBoxVertices

            elipsoidHans1.createEllipsoid(-4.2f, -7.5f, 0, 1, 1.2f, 1f, 100, 100);
            elipsoidHans2.createEllipsoid(-4.6f, -7.1f, 0.6f, 0.2f, 0.3f, 0.3f, 100, 100);
            elipsoidHans3.createEllipsoid(-3.8f, -7.1f, 0.6f, 0.2f, 0.3f, 0.3f, 100, 100);

            tubeHans1.createTube1(0.25f, 0.2f, 0.5f, -4.2f, -7.5f, 0.75f, 100, 3);
            hidungKanan.createEllipsoid(-4.1f, -7.5f, 1.25f, 0.05f, 0.05f, 0.05f, 100, 100);
            hidungKiri.createEllipsoid(-4.3f, -7.5f, 1.25f, 0.05f, 0.05f, 0.05f, 100, 100);

            tubeHans2.createTube1(1f, 1f, 3f, -4.2f, -7.75f, -3.5f, 100, 3);
            elipsoidHans4.createEllipsoid(-4.2f, -7.77f, -3.3f, 0.9f, 0.9f, 0.89f, 100, 100);
            kakidepankiri.createTubeHans(0.3f, 0.9f, 0.6f, -4.7f, -8.8f, -1f, 100, 3);
            kakidepankanan.createTubeHans(0.3f, 0.9f, 0.6f, -3.7f, -8.8f, -1f, 100, 3);
            kakibelakangkiri.createTubeHans(0.3f, 0.9f, 0.6f, -4.7f, -8.8f, -2.7f, 100, 3);
            kakibelakangkanan.createTubeHans(0.3f, 0.9f, 0.6f, -3.7f, -8.8f, -2.7f, 100, 3);




            //Land.createRectangle(-3f, -13.95f, -5.15f, 1000f, 10f, 500f);

            //ellips6.createEllipsoid(0.5f, -0.7f, -0.6f, 0.80f, 1.05f, 1, 100, 100);

            
            //objectList.Add(cube1);
            StickMan.Add(cuberand);
            StickMan.Add(persegipanjang);
            StickMan.Add(persegipanjang2);
            StickMan.Add(persegipanjang3);
            StickMan.Add(persegipanjang4);
            StickMan.Add(persegipanjang5);




            objectList.Add(cube2);
            objectList.Add(cube3);
            objectList.Add(ellips1);
            //objectList.Add(cube5);
            //objectList.Add(torus1);
            objectList.Add(cube4);
            objectList.Add(cube5);
            objectList.Add(ellips2);
            objectList.Add(ellips3);
            objectList.Add(ellips4);
            objectList.Add(ellips5);
            objectList.Add(ellips6);
            objectList.Add(ellips7);
            objectList.Add(ellips8);
            objectList.Add(ellips9);
            objectList.Add(ellips10);
            objectList.Add(ellips11);
            objectList.Add(ellips12);
            objectList.Add(ellips13);
            objectList.Add(ellips14);
            objectList.Add(ellips15);
            objectList.Add(ellips16);
            objectList.Add(ellips17);
            objectList.Add(ellips18);
            objectList.Add(ellips19);
            objectList.Add(ellips20);
            objectList.Add(ellips21);
            objectList.Add(ellips22);
            objectList.Add(ellips23);
            objectList.Add(ellips24);
            objectList.Add(ellips25);
            //objectList.Add(ellips26);
            //wobjectList.Add(ellips27);
            objectList.Add(ellips28);
            objectList.Add(ellips29);
            objectList.Add(ellips30);
            objectList.Add(ellips31);
            objectList.Add(Tube1);
            objectList.Add(Tube2);
            objectList.Add(Tube3);
            objectList.Add(Tube4);
            objectList.Add(Tube5);
            objectList.Add(Tube6);
            objectList.Add(Tube7);
            objectList.Add(Tube8);
            objectList.Add(Tube9);
            objectList.Add(rectangle1);
            objectList.Add(rectangle2);
            objectList.Add(rectangle3);
            objectList.Add(rectangle4);
            objectList.Add(rectangle5);
            objectList.Add(rectangle6);
            objectList.Add(rectangle7);
            objectList.Add(rectangle8);
            objectList.Add(rectangle9);

            //alvin
            objectListAlvin.Add(alvinellips1);
            objectListAlvin.Add(alvinellips2);
            objectListAlvin.Add(alvinellips3);
            objectListAlvin.Add(alvinellips4);
            objectListAlvin.Add(alvinellips5);
            objectListAlvin.Add(alvinellips6);
            objectListAlvin.Add(alvintube1);
            objectListAlvin.Add(alvintube2);
            objectListAlvin.Add(alvintube3);
            objectListAlvin.Add(alvintube4);
            objectListAlvin.Add(alvinellips7);

            objectListAlvin.Add(alvinellips8);
            objectListAlvin.Add(alvinellips9);
            objectListAlvin.Add(alvinellips10);
            objectListAlvin.Add(alvinellips11);
            objectListAlvin.Add(alvintriangle1);
            objectListAlvin.Add(alvinellips12);
            objectListAlvin.Add(alvinellips13);
            objectListAlvin.Add(alvinellips14);
            objectListAlvin.Add(alvinellips15);
            objectListAlvin.Add(alvinellips16);
            objectListAlvin.Add(alvinellips1);
            objectListAlvin.Add(alvinellips2);
            objectListAlvin.Add(alvinellips3);
            objectListAlvin.Add(alvinellips4);
            objectListAlvin.Add(alvinellips5);
            objectListAlvin.Add(alvinellips6);
            objectListAlvin.Add(alvintube1);
            objectListAlvin.Add(alvintube2);
            objectListAlvin.Add(alvintube3);
            objectListAlvin.Add(alvintube4);
            objectListAlvin.Add(alvinellips7);
            objectListAlvin.Add(alvinellips8);
            objectListAlvin.Add(alvinellips9);
            objectListAlvin.Add(alvinellips10);
            objectListAlvin.Add(alvinellips11);
            objectListAlvin.Add(alvintriangle1);
            objectListAlvin.Add(alvinellips12);
            objectListAlvin.Add(alvinellips13);
            objectListAlvin.Add(alvinellips14);
            objectListAlvin.Add(alvinellips15);
            objectListAlvin.Add(alvinellips16);

            //environments
            objectListEnvironment.Add(Land);
            objectListEnvironment.Add(Road);
            objectListEnvironment.Add(Road2);
            objectListEnvironment.Add(Road3);
            objectListEnvironment.Add(Roadstrip);
            objectListEnvironment.Add(Roadstrip2);
            objectListEnvironment.Add(Roadstrip3);
            objectListEnvironment.Add(Roadstrip4);
            objectListEnvironment.Add(Roadstrip5);
            objectListEnvironment.Add(Roadstrip6);
            objectListEnvironment.Add(parkinglot);
            objectListEnvironment.Add(parkingstrip1);

            objectListEnvironment.Add(tiang1);
            objectListEnvironment.Add(tiang2);
            objectListEnvironment.Add(tiangatas);

            objectListEnvironment.Add(talikiri);
            objectListEnvironment.Add(talikanan);
            objectListEnvironment.Add(ayunankayu);
            objectListEnvironment.Add(talidonutkiri);
            objectListEnvironment.Add(talidonutkanan);


            objectListEnvironment.Add(pagarvert);
            objectListEnvironment.Add(pagarvert2);
            objectListEnvironment.Add(pagarvert3);
            objectListEnvironment.Add(pagarvert4);
            objectListEnvironment.Add(pagarvert5);
            objectListEnvironment.Add(pagarvert6);
            objectListEnvironment.Add(pagarvert7);
            objectListEnvironment.Add(pagarvert8);
            objectListEnvironment.Add(pagarvert9);
            objectListEnvironment.Add(pagarvert10);
            objectListEnvironment.Add(pagarvert11);
            objectListEnvironment.Add(pagarvert12);
            objectListEnvironment.Add(pagarvert13);
            objectListEnvironment.Add(pagarvert14);
            objectListEnvironment.Add(pagarvert15);
            objectListEnvironment.Add(pagarvert16);
            objectListEnvironment.Add(pagarvert17);
            objectListEnvironment.Add(pagarvert18);
            objectListEnvironment.Add(pagarvert19);
            objectListEnvironment.Add(pagarvert20);
            objectListEnvironment.Add(pagarvert21);
            objectListEnvironment.Add(pagarvert22);
            objectListEnvironment.Add(pagarvert23);
            objectListEnvironment.Add(pagarvert24);
            objectListEnvironment.Add(pagarvert25);
            objectListEnvironment.Add(pagarvert26);
            objectListEnvironment.Add(pagarvert27);
            objectListEnvironment.Add(pagarvert28);
            objectListEnvironment.Add(pagarvert29);
            objectListEnvironment.Add(pagarvert30);
            objectListEnvironment.Add(pagarvert31);
            objectListEnvironment.Add(pagarvert32);
            objectListEnvironment.Add(pagarvert33);
            objectListEnvironment.Add(pagarvert34);
            objectListEnvironment.Add(pagarvert35);
            objectListEnvironment.Add(pagarvert36);
            objectListEnvironment.Add(pagarvert37);
            objectListEnvironment.Add(pagarvert38);
            objectListEnvironment.Add(pagarvert39);
            objectListEnvironment.Add(pagarvert40);
            objectListEnvironment.Add(pagarvert41);
            objectListEnvironment.Add(pagarvert42);
            objectListEnvironment.Add(pagarvert43);
            objectListEnvironment.Add(pagarvert44);
            objectListEnvironment.Add(pagarvert45);
            objectListEnvironment.Add(pagarvert46);
            objectListEnvironment.Add(pagarvert47);
            objectListEnvironment.Add(pagarvert48);
            objectListEnvironment.Add(pagarvert49);
            objectListEnvironment.Add(pagarvert50);
            objectListEnvironment.Add(pagarvert51);
            objectListEnvironment.Add(pagarvert52);
            objectListEnvironment.Add(pagarvert53);
            objectListEnvironment.Add(pagarvert54);
            objectListEnvironment.Add(pagarvert55);
            objectListEnvironment.Add(pagarvert56);
            objectListEnvironment.Add(pagarvert57);
            objectListEnvironment.Add(pagarvert58);
            objectListEnvironment.Add(pagarvert59);
            objectListEnvironment.Add(pagarvert60);
            objectListEnvironment.Add(pagarvert61);
            objectListEnvironment.Add(pagarvert62);
            objectListEnvironment.Add(pagarvert63);
            objectListEnvironment.Add(pagarvert64);
            objectListEnvironment.Add(pagarvert65);
            objectListEnvironment.Add(pagarvert66);
            objectListEnvironment.Add(pagarvert67);
            objectListEnvironment.Add(pagarvert68);
            objectListEnvironment.Add(pagarvert69);
            objectListEnvironment.Add(pagarvert70);
            objectListEnvironment.Add(pagarvert71);
            objectListEnvironment.Add(pagarvert72);
            objectListEnvironment.Add(pagarvert73);
            objectListEnvironment.Add(pagarvert74);
            objectListEnvironment.Add(pagarvert75);
            objectListEnvironment.Add(pagarvert76);
            objectListEnvironment.Add(pagarvert77);
            objectListEnvironment.Add(pagarvert78);
            objectListEnvironment.Add(pagarvert79);
            objectListEnvironment.Add(pagarvert80);
            objectListEnvironment.Add(pagarvert81);
            objectListEnvironment.Add(pagarvert82);
            objectListEnvironment.Add(pagarvert83);
            objectListEnvironment.Add(pagarvert84);
            objectListEnvironment.Add(pagarvert85);
            objectListEnvironment.Add(pagarvert86);
            objectListEnvironment.Add(pagarvert87);
            objectListEnvironment.Add(pagarvert88);
            objectListEnvironment.Add(pagarvert89);
            objectListEnvironment.Add(pagarvert90);
            
            //pagar pintu depan
            objectListPintuDepan.Add(pagarvert91);
            objectListPintuDepan.Add(pagarvert92);
            objectListPintuDepan.Add(pagarvert93);
            objectListPintuDepan.Add(pagarvert94);
            objectListPintuDepan.Add(pagarvert95);
            //objectListEnvironment.Add(pagarvert96);
            objectListPintuDepan2.Add(pagarvert97);
            objectListPintuDepan2.Add(pagarvert98);
            objectListPintuDepan2.Add(pagarvert99);
            objectListPintuDepan2.Add(pagarvert100);
            
            objectListEnvironment.Add(pagarvert101);
            objectListEnvironment.Add(pagarvert102);
            objectListEnvironment.Add(pagarvert103);
            objectListEnvironment.Add(pagarvert104);
            objectListEnvironment.Add(pagarvert105);
            objectListEnvironment.Add(pagarvert106);
            objectListEnvironment.Add(pagarvert107);
            objectListEnvironment.Add(pagarvert108);
            objectListEnvironment.Add(pagarvert109);
            objectListEnvironment.Add(pagarvert110);
            objectListEnvironment.Add(pagarvert111);
            objectListEnvironment.Add(pagarvert112);
            objectListEnvironment.Add(pagarvert113);
            objectListEnvironment.Add(pagarvert114);
            objectListEnvironment.Add(pagarvert115);
            objectListEnvironment.Add(pagarvert116);
            objectListEnvironment.Add(pagarvert117);
            objectListEnvironment.Add(pagarvert118);
            objectListEnvironment.Add(pagarvert119);
            objectListEnvironment.Add(pagarvert120);
            objectListEnvironment.Add(pagarvert121);
            objectListEnvironment.Add(pagarvert122);
            objectListEnvironment.Add(pagarvert123);
            objectListEnvironment.Add(pagarvert124);
            objectListEnvironment.Add(pagarvert125);
            objectListEnvironment.Add(pagarvert126);
            objectListEnvironment.Add(pagarvert127);
            objectListEnvironment.Add(pagarvert128);
            objectListEnvironment.Add(pagarvert129);
            objectListEnvironment.Add(pagarvert130);
            objectListEnvironment.Add(pagarvert131);
            objectListEnvironment.Add(pagarvert132);
            objectListEnvironment.Add(pagarvert133);
            objectListEnvironment.Add(pagarvert134);
            objectListEnvironment.Add(pagarvert135);
            objectListEnvironment.Add(pagarvert136);
            objectListEnvironment.Add(pagarvert137);
            objectListEnvironment.Add(pagarvert138);
            objectListEnvironment.Add(pagarvert139);

            //kandang pertama
            objectListEnvironment.Add(pagarvert140);
            objectListEnvironment.Add(pagarvert141);
            objectListEnvironment.Add(pagarvert142);
            objectListEnvironment.Add(pagarvert143);
            objectListEnvironment.Add(pagarvert144);
            objectListEnvironment.Add(pagarvert145);
            objectListEnvironment.Add(pagarvert146);
            objectListEnvironment.Add(pagarvert147);
            objectListEnvironment.Add(pagarvert148);
            objectListEnvironment.Add(pagarvert149);
            objectListEnvironment.Add(pagarvert150);
            objectListEnvironment.Add(pagarvert151);
            objectListEnvironment.Add(pagarvert152);
            objectListEnvironment.Add(pagarvert153);

            objectListEnvironment.Add(pagarvert154);
            objectListEnvironment.Add(pagarvert155);
            objectListEnvironment.Add(pagarvert156);
            objectListEnvironment.Add(pagarvert157);
            objectListEnvironment.Add(pagarvert158);
            objectListEnvironment.Add(pagarvert159);
            objectListEnvironment.Add(pagarvert160);
            objectListEnvironment.Add(pagarvert161);
            objectListEnvironment.Add(pagarvert162);
            objectListEnvironment.Add(pagarvert163);
            objectListEnvironment.Add(pagarvert164);
            objectListEnvironment.Add(pagarvert165);
            objectListEnvironment.Add(pagarvert166);
            objectListEnvironment.Add(pagarvert167);
            
            objectListEnvironment.Add(pagarvert168);
            objectListEnvironment.Add(pagarvert169);
            objectListEnvironment.Add(pagarvert170);
            objectListEnvironment.Add(pagarvert171);
            objectListEnvironment.Add(pagarvert172);
            objectListEnvironment.Add(pagarvert173);
            objectListEnvironment.Add(pagarvert174);
            objectListEnvironment.Add(pagarvert175);
            objectListEnvironment.Add(pagarvert176);
            objectListEnvironment.Add(pagarvert177);
            objectListEnvironment.Add(pagarvert178);
            objectListEnvironment.Add(pagarvert179);
            objectListEnvironment.Add(pagarvert180);
            objectListEnvironment.Add(pagarvert181);
            objectListEnvironment.Add(pagarvert182);

            //kandang kedua
            objectListEnvironment.Add(pagarvert183);
            objectListEnvironment.Add(pagarvert184);
            objectListEnvironment.Add(pagarvert185);
            objectListEnvironment.Add(pagarvert186);
            objectListEnvironment.Add(pagarvert187);
            objectListEnvironment.Add(pagarvert188);
            objectListEnvironment.Add(pagarvert189);
            objectListEnvironment.Add(pagarvert190);
            objectListEnvironment.Add(pagarvert191);
            objectListEnvironment.Add(pagarvert192);
            objectListEnvironment.Add(pagarvert193);
            objectListEnvironment.Add(pagarvert194);

            //pagar pintu depan
            objectListPintuDepan2.Add(pagarvert195);

            //buat pagar kandang
            objectListEnvironment.Add(pagarvert196);
            objectListEnvironment.Add(pagarvert197);
            objectListEnvironment.Add(pagarvert198);
            objectListEnvironment.Add(pagarvert199);
            objectListEnvironment.Add(pagarvert200);
            objectListEnvironment.Add(pagarvert201);
            //pintu kandag 1
            objectListPintuKandangKucing.Add(pagarvert202);
            objectListPintuKandangKucing.Add(pagarvert203);
            objectListPintuKandangKucing.Add(pagarvert204);
            objectListPintuKandangKucing.Add(pagarvert205);
            objectListPintuKandangKucing.Add(pagarvert206);
            objectListPintuKandangKucing.Add(pagarvert207);
            
            //pagar kandang tengah
            objectListEnvironment.Add(pagarvert208);
            objectListEnvironment.Add(pagarvert209);
            objectListEnvironment.Add(pagarvert210);
            objectListEnvironment.Add(pagarvert211);
            objectListEnvironment.Add(pagarvert212);
            objectListEnvironment.Add(pagarvert213);
            objectListEnvironment.Add(pagarvert214);
            objectListEnvironment.Add(pagarvert215);
            objectListEnvironment.Add(pagarvert216);
            objectListEnvironment.Add(pagarvert217);
            //pintu pagar tengah
            objectListPintuKandangPanda.Add(pagarvert218);
            objectListPintuKandangPanda.Add(pagarvert219);
            objectListPintuKandangPanda.Add(pagarvert220);
            objectListPintuKandangPanda.Add(pagarvert221);
            objectListPintuKandangPanda.Add(pagarvert222);
            objectListPintuKandangPanda.Add(pagarvert223);
            objectListPintuKandangPanda.Add(pagarvert224);
            objectListPintuKandangPanda.Add(pagarvert225);
            objectListPintuKandangPanda.Add(pagarvert226);
            
            objectListEnvironment.Add(pagarvert227);
            objectListEnvironment.Add(pagarvert228);
            objectListEnvironment.Add(pagarvert229);
            objectListEnvironment.Add(pagarvert230);
            objectListEnvironment.Add(pagarvert231);
            objectListEnvironment.Add(pagarvert232);
            objectListEnvironment.Add(pagarvert233);
            objectListEnvironment.Add(pagarvert234);
            objectListEnvironment.Add(pagarvert235);
            objectListEnvironment.Add(pagarvert236);
            
            //pintu babi
            objectListPintuKandangBabi.Add(pagarvert237);
            objectListPintuKandangBabi.Add(pagarvert238);
            objectListPintuKandangBabi.Add(pagarvert239);
            objectListPintuKandangBabi.Add(pagarvert240);
            objectListPintuKandangBabi.Add(pagarvert241);
            objectListPintuKandangBabi.Add(pagarvert242);
            objectListPintuKandangBabi.Add(pagarvert243);



            objectListEnvironment.Add(pagarvert167);


            objectListEnvironment.Add(pagarhori1);
            objectListEnvironment.Add(pagarhori2);
            objectListEnvironment.Add(pagarhori3);
            objectListEnvironment.Add(pagarhori4);
            objectListEnvironment.Add(pagarhori5);
            objectListEnvironment.Add(pagarhori6);
            objectListEnvironment.Add(pagarhori7);

            objectListEnvironment.Add(bambu1);
            objectListEnvironment.Add(bambu2);
            objectListEnvironment.Add(bambu3);
            objectListEnvironment.Add(bambu4);
            objectListEnvironment.Add(bambu5);
            objectListEnvironment.Add(bambu6);

            objectListEnvironment.Add(bambutorus1);
            objectListEnvironment.Add(bambutorus2);
            objectListEnvironment.Add(bambutorus3);
            objectListEnvironment.Add(bambutorus4);
            objectListEnvironment.Add(bambutorus5);
            objectListEnvironment.Add(bambutorus6);
            objectListEnvironment.Add(bambutorus7);
            objectListEnvironment.Add(bambutorus8);
            objectListEnvironment.Add(bambutorus9);
            objectListEnvironment.Add(bambutorus10);
            objectListEnvironment.Add(bambutorus11);

            //pagar pintu depan HORI
            objectListPintuDepan.Add(pagarhori8);
            objectListPintuDepan2.Add(pagarhori9);

            //paagr pintu kandang pertama hori
            objectListPintuKandangKucing.Add(pagarhori10);
            objectListPintuKandangPanda.Add(pagarhori11);
            objectListPintuKandangBabi.Add(pagarhori12);


            //cloud
            objectListCloud.Add(cloud1);
            objectListCloud.Add(cloud2);
            objectListCloud.Add(cloud3);
            objectListCloud.Add(cloud4);
            objectListCloud2.Add(cloud5);
            objectListCloud2.Add(cloud6);
            objectListCloud2.Add(cloud7);
            objectListCloud2.Add(cloud8);





            //hans
            objectListHans.Add(cube2Hans);
            objectListHans.Add(cube3Hans);
            objectListHans.Add(elipsoidHans1);
            objectListHans.Add(elipsoidHans2);
            objectListHans.Add(elipsoidHans3);
            objectListHans.Add(tubeHans1);
            objectListHans.Add(hidungKiri);
            objectListHans.Add(hidungKanan);
            objectListHans.Add(tubeHans2);
            objectListHans.Add(elipsoidHans4);
            objectListHans.Add(kakidepankiri);
            objectListHans.Add(kakidepankanan);
            objectListHans.Add(kakibelakangkiri);
            objectListHans.Add(kakibelakangkanan);

            //Environment
            objectList2.Add(Land);

            LightObject.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);
            foreach (Asset3d i in StickMan)
            {
                //i.load( Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);
            }

            foreach (Asset3d i in objectList)
            {
                //i.load( Size.X, Size.Y);

                 i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);
            }
            foreach (Asset3d i in objectList2)
            {
                //i.load( Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);

            }
            foreach (Asset3d i in objectList3)
            {
                //i.load( Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListAlvin)
            {

                //i.load( Size.X, Size.Y);

                i.load_withnormal(Constants.path + "shaderwithNormal.vert", Constants.path + "objectnew.frag", Size.X, Size.Y);
            }
            foreach (Asset3d i in objectListEnvironment)
            {
                //i.load( Size.X, Size.Y);
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListHans)
            {
                //i.load( Size.X, Size.Y);
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListCloud)
            {
               //i.load( Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListCloud2)
            {
                //i.load(Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListPintuDepan)
            {
                //i.load( Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);

            }
            foreach (Asset3d i in objectListPintuDepan2)
            {
                //i.load( Size.X, Size.Y);
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListPintuKandangKucing)
            {
                //i.load( Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListPintuKandangPanda)
            {
                //i.load( Size.X, Size.Y);
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);


            }
            foreach (Asset3d i in objectListPintuKandangBabi)
            {
                //i.load( Size.X, Size.Y);

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", Size.X, Size.Y);

            }
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            //jalan();

            float time = (float)args.Time; //Deltatime ==> waktu antara frame sebelumnya ke frame berikutnya, gunakan untuk animasi
                                           //translasi kucin


            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // DepthBufferBit juga harus di clear karena kita memakai depth testing.
            //dLightObject.render(3, time, anim, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());

            foreach (Asset3d i in StickMan)
            {
                i.render(0, time, MatStickMan, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                //i.rotate(Vector3.UnitZ, Vector3.UnitY, 5 * time);
                i.setFragVariable(new Vector3(0.35f, 087f, 0.31f), new Vector3(1f, 1f, 1f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(0.5f, 0.4f, 0.7f);

            }
            foreach (Asset3d i in objectList)
            {
                i.render(0, time, anim, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                //i.rotate(Vector3.UnitZ, Vector3.UnitY, 5 * time);
                i.setFragVariable(new Vector3(0.35f, 087f, 0.31f), new Vector3(1f, 1f, 1f)); 
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                if (KucingTranslasi == 0)
                {
                    foreach (Asset3d j in objectList)
                    {
                        j.translate(-5f, 0f, 0f);
                    }

                    KucingTranslasi = 1;
                }
                if (KeyboardState.IsKeyDown(Keys.F1))
                {
                    berhenti = 0;
                    i.translate(0, 0, 0.01f);

                }
                if (berhenti <= 1000)
                {
                   i.translate(0, 0, 0.01f);
                    berhenti = berhenti + 1;
                }

                if (berhenti == 1000)
                {
                    berhenti1 = 1000;
                }

                if (berhenti1 >= 0)
                {
                    i.translate(0, 0, -0.01f);
                    berhenti1 = berhenti1 - 1;
                }

                if (berhenti1 == 0)
                {
                    berhenti = 0;
                }

                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);


                }
            }
            foreach (Asset3d i in objectListAlvin)
            {
                i.render(0, time, anim2, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());


                //i.rotateAlvin(i.centerPosition, Vector3.UnitY, 5 * time);
                i.setFragVariable(new Vector3(0.35f, 087f, 0.31f), new Vector3(1,1,1));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);
                if (PandaTranslasi == 0)
                {
                    foreach (Asset3d j in objectListAlvin)
                    {
                        j.translate(-2f, 0f, 0f);
                    }

                    PandaTranslasi = 1;
                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(j.centerPosition, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListEnvironment)
            {
                i.render(0, time, anim4, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }


                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);

                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);

                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListHans)
            {
                i.render(0, time, anim3, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());

                i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotateHans(Vector3.UnitZ, Vector3.UnitY, 20 * time);
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);
                if (BabiTranslasi == 0)
                {
                    foreach (Asset3d j in objectListHans)
                    {
                        j.translate(0f, 0f, -8f);
                    }

                    BabiTranslasi = 1;
                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(j.centerPosition, Vector3.UnitY, 720 * time);

                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListCloud)
            {
                i.render(0, time, Cloud, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                i.render(0, time, Cloud2, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());

                i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);

                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);
                if (berhenticloud <= 1000)
                {
                    i.translate(0.05f, 0, 0);

                    berhenticloud = berhenticloud + 1;
                }

                if (berhenticloud == 1000)
                {
                    berhenticloud1 = 1000;
                }

                if (berhenticloud1 >= 0)
                {
                    i.translate(-0.05f, 0, 0);

                    berhenticloud1 = berhenticloud1 - 1;
                }

                if (berhenticloud1 == 0)
                {
                    berhenticloud = 0;
                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListCloud2)
            {
                i.render(0, time, Cloud2, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());

                i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);

                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);
                if (berhenticloud <= 1000)
                {
                    i.translate(-0.05f, 0, 0);

                    berhenticloud = berhenticloud + 1;
                }

                if (berhenticloud == 1000)
                {
                    berhenticloud1 = 1000;
                }

                if (berhenticloud1 >= 0)
                {
                    i.translate(0.05f, 0, 0);

                    berhenticloud1 = berhenticloud1 - 1;
                }

                if (berhenticloud1 == 0)
                {
                    berhenticloud = 0;
                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListPintuDepan)
            {
                i.render(0, time, PintuDepan, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }

                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);

                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);
                if (KeyboardState.IsKeyDown(Keys.Tab))
                {
                    berhentiPagar = 0;


                }
                if (berhentiPagar <= 900)
                {
                    i.translate(-0.05f, 0, 0);

                    berhentiPagar = berhentiPagar + 1;
                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListPintuDepan2)
            {
                i.render(0, time, PintuDepan2, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());

                i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);

                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);
                if (KeyboardState.IsKeyDown(Keys.Tab))
                {
                    berhentiPagar = 0;


                }
                if (berhentiPagar <= 900)
                {
                    i.translate(0.05f, 0, 0);

                    berhentiPagar = berhentiPagar + 1;
                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListPintuKandangKucing)
            {
                i.render(0, time, PintuKandangKucing, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());

                i.setFragVariable(new Vector3(0f, 0, 0f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }
                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);
                if (KeyboardState.IsKeyDown(Keys.M))
                {
                    berhentiPagarKucing = 0;

                }
                if (berhentiPagarKucing <= 900)
                {
                    //PintuKandangKucing = PintuKandangKucing * Matrix4.CreateTranslation(0f, 0, 0.005f);
                    i.translate(0,0,0.03f);
                    berhentiPagarKucing = berhentiPagarKucing + 1;
                }
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);

                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListPintuKandangPanda)
            {
                i.render(0, time, PintuKandangPanda, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }

                //i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                //i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);

                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);
                if (KeyboardState.IsKeyDown(Keys.N))
                {
                    berhentiPagarPanda = 0;

                }
                if (berhentiPagarPanda <= 900)
                {
                    i.translate(0f, 0, 0.05f);

                    berhentiPagarPanda = berhentiPagarPanda + 1;
                }
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            foreach (Asset3d i in objectListPintuKandangBabi)
            {
                i.render(0, time, PintuKandangBabi, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                i.setFragVariable(new Vector3(0.5f, 0.7f, 0.81f), new Vector3(1.0f, 1.0f, 1.0f));
                i.setSpecularDiffuseVariable(LightObject.centerPosition, _camera.Position);
                bool check = i.checkCollision(i.centerPosition, _camera, 1, 1);
                if (check)
                {
                    _camera.Position = new Vector3(0, 10, 0);
                }

                if (KeyboardState.IsKeyDown(Keys.B))
                {
                    berhentiPagarBabi = 0;

                }
                if (berhentiPagarBabi <= 900)
                {
                    i.translate(0f, 0, 0.05f);

                    berhentiPagarBabi = berhentiPagarBabi + 1;
                }
                //i.rotateAlvin(Vector3.UnitZ, Vector3.UnitY, 10 * time);

                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                //i.translate(1,1,1);

                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);

                }
            }
            if (KeyboardState.IsKeyDown(Keys.F1))
            {
                berhenti = 0;


            }
            if (berhenti <= 1000)
            {
                anim = anim * Matrix4.CreateTranslation(0, 0, 0.01f);
                berhenti = berhenti + 1;
            }

            if (berhenti == 1000)
            {
                berhenti1 = 1000;
            }

            if (berhenti1 >= 0)
            {
                anim = anim * Matrix4.CreateTranslation(0, 0, -0.01f);
                berhenti1 = berhenti1 - 1;
            }

            if (berhenti1 == 0)
            {
                berhenti = 0;
            }
            //rotasi panda
            if (AwalPosisiPanda == 0)
            {
                anim2 = anim2 * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(90f));
                AwalPosisiPanda = AwalPosisiPanda + 1;
            }
            if (AwalPosisiPanda == 1)
            {
                anim2 = anim2 * Matrix4.CreateTranslation(-7.5f, 0, 0);
                berhentiobject = berhentiobject + 1;
                AwalPosisiPanda = AwalPosisiPanda + 1;

            }


            //awan
            if (berhenticloud <= 1000)
            {
                Cloud = Cloud * Matrix4.CreateTranslation(0.005f, 0, 0);
                Cloud2 = Cloud2 * Matrix4.CreateTranslation(-0.005f, 0, 0);

                berhenticloud = berhenticloud + 1;
            }

            if (berhenticloud == 1000)
            {
                berhenticloud1 = 1000;
            }

            if (berhenticloud1 >= 0)
            {
                Cloud = Cloud * Matrix4.CreateTranslation(-0.005f, 0, 0);
                Cloud2 = Cloud2 * Matrix4.CreateTranslation(0.005f, 0, 0);

                berhenticloud1 = berhenticloud1 - 1;
            }

            if (berhenticloud1 == 0)
            {
                berhenticloud = 0;
            }

            //Pagar Pintu Depan
            //translasi kucing
            if (KeyboardState.IsKeyDown(Keys.Tab))
            {
                berhentiPagar = 0;


            }
            if (berhentiPagar <= 900)
            {
                PintuDepan = PintuDepan * Matrix4.CreateTranslation(-0.005f, 0, 0);
                PintuDepan2 = PintuDepan2 * Matrix4.CreateTranslation(0.005f, 0, 0);

                berhentiPagar = berhentiPagar + 1;
            }

            //pagar kucing
            if (KeyboardState.IsKeyDown(Keys.M))
            {
                berhentiPagarKucing = 0;

            }
            if (berhentiPagarKucing <= 900)
            {
                PintuKandangKucing = PintuKandangKucing * Matrix4.CreateTranslation(0f, 0, 0.005f);

                berhentiPagarKucing = berhentiPagarKucing + 1;
            }
            //pagar Panda
            if (KeyboardState.IsKeyDown(Keys.N))
            {
                berhentiPagarPanda = 0;

            }
            if (berhentiPagarPanda <= 900)
            {
                PintuKandangPanda = PintuKandangPanda * Matrix4.CreateTranslation(0f, 0, 0.005f);

                berhentiPagarPanda = berhentiPagarPanda + 1;
            }
            //rotasi panda lagi
            if (berhentiPagarPanda == 900)
            {
                RotasiPanda = 900;

            }
            if (RotasiPanda >= 0)
            {
                anim2 = anim2 * Matrix4.CreateTranslation(0.005f, 0, 0);
                RotasiPanda = RotasiPanda - 1;
            }
            if (RotasiPanda == 0)
            {
                berhentiobjectTemp = 0;
            }
            if (berhentiobjectTemp <= 800)
            {
                anim2 = anim2 * Matrix4.CreateTranslation(0.005f, 0, 0);
            }
            if (berhentiobjectTemp <= 900)
            {
                anim2 = anim2 * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(-0.1f));
                berhentiobjectTemp = berhentiobjectTemp + 1;
            }

            //rotasi pivot ini
            //if (RotasiPanda >= 0)
            //{
            //    anim2 = anim2 * Matrix4.CreateTranslation(0f, 0, 0.005f);
            //    RotasiPanda = RotasiPanda + 1;
            //}
            //pagar babi
            if (KeyboardState.IsKeyDown(Keys.B))
            {
                berhentiPagarBabi = 0;

            }
            if (berhentiPagarBabi <= 900)
            {
                PintuKandangBabi = PintuKandangBabi * Matrix4.CreateTranslation(0f, 0, 0.005f);

                berhentiPagarBabi = berhentiPagarBabi + 1;
            }

            SwapBuffers();
        }
        public async void jalan()
        {
            for (int i = 0; i <= 2; i++)
            {
                anim = anim * Matrix4.CreateTranslation(0, 0, 0.001f);
                anim2 = anim2 * Matrix4.CreateTranslation(0, 0, 0.001f);
                anim3 = anim3 * Matrix4.CreateTranslation(0, 0, 0.001f);
                //anim4 = anim4 * Matrix4.CreateTranslation(0, 0, 0.001f);
                Cloud = Cloud * Matrix4.CreateTranslation(0, 0, 0.001f);
                Cloud2 = Cloud * Matrix4.CreateTranslation(0, 0, 0.001f);
                PintuDepan = PintuDepan * Matrix4.CreateTranslation(0, 0, 0.001f);
                PintuDepan2 = PintuDepan2 * Matrix4.CreateTranslation(0, 0, 0.001f);
                PintuKandangKucing = PintuKandangKucing * Matrix4.CreateTranslation(0, 0, 0.001f);
                PintuKandangPanda = PintuKandangPanda * Matrix4.CreateTranslation(0, 0, 0.001f);
                PintuKandangBabi = PintuKandangBabi * Matrix4.CreateTranslation(0, 0, 0.001f);





                await Task.Delay(100);
            }
        }
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);

            float time = (float)args.Time; //Deltatime ==> waktu antara frame sebelumnya ke frame berikutnya, gunakan untuk animasi
            float cameraSpeed = 5f;
            if (!IsFocused)
            {
                return; //Reject semua input saat window bukan focus.
            }


            var input = KeyboardState;
            if (KeyboardState.IsKeyDown(Keys.W))
            {
                // jika kepala belum lurus
                if (_camera.Yaw > -90 && !headDir)
                {
                    _camera.Yaw -= cameraSpeed * (float)args.Time * 10;
                }
                else if (_camera.Yaw < -90 && !headDir)
                {
                    _camera.Yaw -= cameraSpeed * (float)args.Time * -10;
                }

                if (_camera.Yaw >= -91 && _camera.Yaw <= -89)
                {
                    headDir = true;
                }
                if (headDir)
                {
                    StickMan[0].translate(0f, 0f, -cameraSpeed * (float)args.Time);
                    StickMan[1].translate(0f, 0f, -cameraSpeed * (float)args.Time);
                    StickMan[2].translate(0f, 0f, -cameraSpeed * (float)args.Time);
                    StickMan[3].translate(0f, 0f, -cameraSpeed * (float)args.Time);
                    StickMan[4].translate(0f, 0f, -cameraSpeed * (float)args.Time);
                    StickMan[5].translate(0f, 0f, -cameraSpeed * (float)args.Time);


                    _camera.Position += _camera.Front * cameraSpeed * (float)args.Time;
                    walking = true;
                }

                Console.WriteLine(_camera.Yaw);

            }

            if (KeyboardState.IsKeyDown(Keys.S))
            {
                _camera.Yaw = -90;
                StickMan[0].translate(0f, 0f, cameraSpeed * (float)args.Time);
                StickMan[1].translate(0f, 0f, cameraSpeed * (float)args.Time);
                StickMan[2].translate(0f, 0f, cameraSpeed * (float)args.Time);
                StickMan[3].translate(0f, 0f, cameraSpeed * (float)args.Time);
                StickMan[4].translate(0f, 0f, cameraSpeed * (float)args.Time);
                StickMan[5].translate(0f, 0f, cameraSpeed * (float)args.Time);
                _camera.Position -= _camera.Front * cameraSpeed * (float)args.Time;
                walking = true;
            }

            if (KeyboardState.IsKeyDown(Keys.A))
            {
                _camera.Yaw = -90;
                StickMan[0].translate(-cameraSpeed * (float)args.Time, 0f, 0f);

                StickMan[1].translate(-cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[2].translate(-cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[3].translate(-cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[4].translate(-cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[5].translate(-cameraSpeed * (float)args.Time, 0f, 0f);

                _camera.Position -= _camera.Right * cameraSpeed * (float)args.Time;
                walking = true;
            }

            if (KeyboardState.IsKeyDown(Keys.D))
            {
                _camera.Yaw = -90;
                StickMan[0].translate(cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[1].translate(cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[2].translate(cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[3].translate(cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[4].translate(cameraSpeed * (float)args.Time, 0f, 0f);
                StickMan[5].translate(cameraSpeed * (float)args.Time, 0f, 0f);
                _camera.Position += _camera.Right * cameraSpeed * (float)args.Time;
                walking = true;
            }

            if (KeyboardState.IsKeyDown(Keys.Space))
            {
                StickMan[0].translate(0f, cameraSpeed * (float)args.Time, 0f);
                StickMan[1].translate(0f, cameraSpeed * (float)args.Time, 0f);
                StickMan[2].translate(0f, cameraSpeed * (float)args.Time, 0f);
                StickMan[3].translate(0f, cameraSpeed * (float)args.Time, 0f);
                StickMan[4].translate(0f, cameraSpeed * (float)args.Time, 0f);
                StickMan[5].translate(0f, cameraSpeed * (float)args.Time, 0f);

                _camera.Position += _camera.Up * cameraSpeed * (float)args.Time;

                Console.WriteLine(_camera.Position.Y);
            }

            if (KeyboardState.IsKeyDown(Keys.Z))
            {
                //if (_camera.Position.Y > 0)
                //{
                StickMan[0].translate(0f, -cameraSpeed * (float)args.Time, 0f);
                StickMan[1].translate(0f, -cameraSpeed * (float)args.Time, 0f);
                StickMan[2].translate(0f, -cameraSpeed * (float)args.Time, 0f);
                StickMan[3].translate(0f, -cameraSpeed * (float)args.Time, 0f);
                StickMan[4].translate(0f, -cameraSpeed * (float)args.Time, 0f);
                StickMan[5].translate(0f, -cameraSpeed * (float)args.Time, 0f);

                _camera.Position -= _camera.Up * cameraSpeed * (float)args.Time;
                //}

                Console.WriteLine(_camera.Position.Y);
            }

            if (KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }


            
            if (KeyboardState.IsKeyDown(Keys.Up))
            {
                _camera.Position += _camera.Front * cameraSpeed * (float)args.Time;

            }

            if (KeyboardState.IsKeyDown(Keys.Down))
            {
                _camera.Yaw = -90;
                _camera.Position -= _camera.Front * cameraSpeed * (float)args.Time;
                walking = true;
            }

            if (KeyboardState.IsKeyDown(Keys.Left))
            {
                _camera.Position -= _camera.Right * cameraSpeed * (float)args.Time;
            }

            if (KeyboardState.IsKeyDown(Keys.Right))
            {
                _camera.Position += _camera.Right * cameraSpeed * (float)args.Time;
            }

            //if (KeyboardState.IsKeyDown(Keys.Space))
            //{
            //    _camera.Position += _camera.Up * cameraSpeed * (float)args.Time;
            //}

            if (KeyboardState.IsKeyDown(Keys.PageDown))
            {
                _camera.Position -= _camera.Up * cameraSpeed * (float)args.Time;
            }

            if (KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }

            ///alvin
            //if (KeyboardState.IsKeyReleased(Keys.U))
            //{
            //    anim2 = anim2 * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(90f));
            //}
            //if (KeyboardState.IsKeyReleased(Keys.I))
            //{
            //    anim2 = anim2 * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(-10f));
            //}

            //if (KeyboardState.IsKeyDown(Keys.F2))
            //{
            //    anim2 = anim2 * Matrix4.CreateTranslation(0, 0, -0.0001f);


            //}
            //if (KeyboardState.IsKeyDown(Keys.F3))
            //{
            //    anim2 = anim2 * Matrix4.CreateTranslation(0.1f, 0, 0f);
            //}
            //if (KeyboardState.IsKeyDown(Keys.F4))
            //{
            //    anim2 = anim2 * Matrix4.CreateTranslation(-0.1f, 0, 0f);
            //}
            ////hans
            //if (KeyboardState.IsKeyReleased(Keys.O))
            //{
            //    anim3 = anim3 * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(10f));
            //}
            //if (KeyboardState.IsKeyReleased(Keys.P))
            //{
            //    anim3 = anim3 * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(-10f));
            //}
            //if (KeyboardState.IsKeyDown(Keys.F6))
            //{
            //    anim3 = anim3 * Matrix4.CreateTranslation(0, 0, 0.1f);
            //}
            //if (KeyboardState.IsKeyDown(Keys.F7))
            //{
            //    anim3 = anim3 * Matrix4.CreateTranslation(0, 0, -0.1f);
            //}
            //if (KeyboardState.IsKeyDown(Keys.F8))
            //{
            //    anim3 = anim3 * Matrix4.CreateTranslation(0.1f, 0, 0f);
            //}
            //if (KeyboardState.IsKeyDown(Keys.F9))
            //{
            //    anim3 = anim3 * Matrix4.CreateTranslation(-0.1f, 0, 0f);
            //}
            ////tony
            //if (KeyboardState.IsKeyReleased(Keys.T))
            //{
            //    anim = anim * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(10f));
            //}
            //if (KeyboardState.IsKeyReleased(Keys.Y))
            //{
            //    anim = anim * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-10f));
            //}

            //if (KeyboardState.IsKeyDown(Keys.Up))
            //{
            //    anim = anim * Matrix4.CreateTranslation(0, 0, 0.1f);
            //}
            //if (KeyboardState.IsKeyDown(Keys.Down))
            //{
            //    anim = anim * Matrix4.CreateTranslation(0, 0, -0.1f);
            //}
            //if (KeyboardState.IsKeyDown(Keys.Left))
            //{
            //    anim = anim * Matrix4.CreateTranslation(0.1f, 0, 0f);
            //}
            //if (KeyboardState.IsKeyDown(Keys.Right))
            //{
            //    anim = anim * Matrix4.CreateTranslation(-0.1f, 0, 0f);
            //}
            var mouse = MouseState;
            var sensitivity = 0.2f;
            if (_firstMove)
            {
                _lastPos = new Vector2(mouse.X, mouse.Y);
                _firstMove = false;
            }
            else
            {
                var deltaX = mouse.X - _lastPos.X;
                var deltaY = mouse.Y - _lastPos.Y;
                _lastPos = new Vector2(mouse.X, mouse.Y);
                _camera.Yaw += deltaX * sensitivity;
                _camera.Pitch -= deltaY * sensitivity;

            }
            //if (KeyboardState.IsKeyReleased(Keys.K))
            //{
            //    anim = anim * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(10));
            //}

            //if (KeyboardState.IsKeyReleased(Keys.I))
            //{
            //    anim = anim * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-10));
            //}
        }
        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Size.X, Size.Y);
        }
    }
}
