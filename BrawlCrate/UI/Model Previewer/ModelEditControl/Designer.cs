﻿using BrawlCrate;
using BrawlLib.OpenGL;
using BrawlLib.SSBB.ResourceNodes;
using System.Collections.Generic;

namespace System.Windows.Forms
{
    public partial class ModelEditControl : ModelEditorBase
    {
        #region Designer

        public ModelPlaybackPanel pnlPlayback;
        public ColorDialog dlgColor;
        public ModelPanel modelPanel;
        public CHR0Editor chr0Editor;
        public SRT0Editor srt0Editor;
        public VIS0Editor vis0Editor;
        public PAT0Editor pat0Editor;
        public SHP0Editor shp0Editor;
        public CLR0Editor clr0Editor;
        public SCN0Editor scn0Editor;

        public ComboBox models;
        private Button btnLeftToggle;
        private Button btnRightToggle;
        private Button btnBottomToggle;
        private Splitter spltLeft;
        private Button btnTopToggle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem openModelsToolStripMenuItem;
        private ToolStripMenuItem notYetImplementedToolStripMenuItem;
        private ToolStripMenuItem newSceneToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem btnUndo;
        private ToolStripMenuItem btnRedo;
        private ToolStripMenuItem viewportToolStripMenuItem;
        private ToolStripMenuItem startTrackingToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem syncKinectToolStripMenuItem;
        private ToolStripMenuItem targetModelToolStripMenuItem;
        private ToolStripMenuItem hideFromSceneToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem hideAllOtherModelsToolStripMenuItem;
        private ToolStripMenuItem deleteAllOtherModelsToolStripMenuItem;
        private ToolStripMenuItem modelToolStripMenuItem;
        private ToolStripMenuItem toggleBones;
        private ToolStripMenuItem togglePolygons;
        private ToolStripMenuItem toggleVertices;
        private ToolStripMenuItem toggleCollisions;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem toggleFloor;
        private ToolStripMenuItem resetCameraToolStripMenuItem;
        private ToolStripMenuItem editorsToolStripMenuItem;
        private ToolStripMenuItem showLeft;
        private ToolStripMenuItem showBottom;
        private ToolStripMenuItem showTop;
        private Panel controlPanel;
        private Splitter spltRight;
        private Panel panel1;
        private ToolStripMenuItem fileTypesToolStripMenuItem;
        private ToolStripMenuItem playCHR0ToolStripMenuItem;
        private ToolStripMenuItem playSRT0ToolStripMenuItem;
        private ToolStripMenuItem playSHP0ToolStripMenuItem;
        private ToolStripMenuItem playPAT0ToolStripMenuItem;
        private ToolStripMenuItem playVIS0ToolStripMenuItem;
        private ToolStripMenuItem openAnimationsToolStripMenuItem;
        private ToolStripMenuItem openMovesetToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem btnOpenClose;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        public Panel animEditors;
        private ToolStrip toolStrip1;
        private Panel panel2;
        private ToolStripButton chkBones;
        private ToolStripButton chkPolygons;
        private ToolStripButton chkVertices;
        private ToolStripButton chkFloor;
        private ToolStripButton button1;
        private ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem chkExternalAnims;
        private Splitter splitter1;
        public Panel animCtrlPnl;
        private ToolStripButton chkCollisions;
        public ToolStripButton btnSaveCam;
        private ToolStripMenuItem showRight;
        public ToolStripMenuItem showCameraCoordinatesToolStripMenuItem;
        private ToolStripMenuItem sCN0ToolStripMenuItem;
        private ToolStripMenuItem editControlToolStripMenuItem;
        private ToolStripMenuItem rotationToolStripMenuItem;
        private ToolStripMenuItem translationToolStripMenuItem;
        private ToolStripMenuItem scaleToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem playCLR0ToolStripMenuItem;
        private WeightEditor weightEditor;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem setColorToolStripMenuItem;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem takeScreenshotToolStripMenuItem;
        private ToolStripMenuItem btnExportToImgNoTransparency;
        private ToolStripMenuItem btnExportToImgWithTransparency;
        private ToolStripMenuItem btnExportToAnimatedGIF;
        private ToolStripMenuItem saveLocationToolStripMenuItem;
        public ToolStripMenuItem ScreenCapBgLocText;
        private ToolStripMenuItem displaySettingToolStripMenuItem;
        private ToolStripMenuItem stretchToolStripMenuItem1;
        private ToolStripMenuItem centerToolStripMenuItem1;
        private ToolStripMenuItem resizeToolStripMenuItem1;
        private ToolStripMenuItem imageFormatToolStripMenuItem;
        private ToolStripMenuItem projectionToolStripMenuItem;
        private ToolStripMenuItem perspectiveToolStripMenuItem;
        public ToolStripMenuItem orthographicToolStripMenuItem;
        private VertexEditor vertexEditor;
        private ToolStripMenuItem boundingBoxToolStripMenuItem;
        private ToolStripMenuItem toggleNormals;
        private ToolStripMenuItem wireframeToolStripMenuItem;
        private ToolStripMenuItem interpolationEditorToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem selectedAnimationToolStripMenuItem;
        private ToolStripMenuItem portToolStripMenuItem;
        private ToolStripMenuItem mergeToolStripMenuItem;
        private ToolStripMenuItem appendToolStripMenuItem;
        private ToolStripMenuItem resizeToolStripMenuItem;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem interpolationToolStripMenuItem;
        private ToolStripMenuItem averageAllStartEndTangentsToolStripMenuItem;
        private ToolStripMenuItem averageboneStartendTangentsToolStripMenuItem;
        private ToolStripMenuItem SLocalToolStripMenuItem;
        private ToolStripMenuItem SWorldToolStripMenuItem;
        private ToolStripMenuItem RLocalToolStripMenuItem;
        private ToolStripMenuItem RWorldToolStripMenuItem;
        private ToolStripMenuItem TLocalToolStripMenuItem;
        private ToolStripMenuItem TWorldToolStripMenuItem;
        public ToolStripMenuItem chkNonBRRESAnims;
        public ToolStripMenuItem chkBRRESAnims;
        private ToolStripButton chkZoomExtents;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripComboBox cboToolSelect;
        private ToolStripDropDownButton dropdownOverlays;
        private ToolStripMenuItem chkAllOverlays;
        private ToolStripMenuItem chkBoundaries;
        private ToolStripMenuItem chkSpawns;
        private ToolStripMenuItem chkItems;
        private ToolStripMenuItem liveTextureFolderToolStripMenuItem;
        public ToolStripMenuItem LiveTextureFolderPath;
        public ToolStripMenuItem EnableLiveTextureFolder;
        public LeftPanel leftPanel;
        private ToolStripMenuItem chkBillboardBones;
        private ToolStripMenuItem chkBBObjects;
        private ToolStripMenuItem chkBBVisBones;
        private ToolStripMenuItem chkBBModels;
        private ToolStripMenuItem chkEditAll;
        private ToolStripMenuItem frontToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem topToolStripMenuItem;
        private ToolStripMenuItem bottomToolStripMenuItem;
        private ToolStripMenuItem detachViewerToolStripMenuItem;
        private ToolStripMenuItem firstPersonCameraToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newViewportLeftToolStripMenuItem;
        private ToolStripMenuItem newViewportAboveToolStripMenuItem;
        private ToolStripMenuItem SCameraToolStripMenuItem;
        private ToolStripMenuItem RCameraToolStripMenuItem;
        private ToolStripMenuItem TCameraToolStripMenuItem;
        private ToolStripMenuItem shadersToolStripMenuItem;
        private ToolStripMenuItem playSCN0ToolStripMenuItem;
        private ToolStripMenuItem removeCurrentViewportToolStripMenuItem;
        private ToolStripMenuItem afterRotationToolStripMenuItem;
        private ToolStripMenuItem btnWeightEditor;
        private ToolStripMenuItem btnVertexEditor;
        private ToolStripMenuItem toggleMetals;
        public RightPanel rightPanel;

        private void InitializeComponent()
        {
            ModelPanelViewport modelPanelViewport1 = new ModelPanelViewport();
            GLCamera glCamera1 = new GLCamera();
            dlgColor = new ColorDialog();
            btnLeftToggle = new Button();
            btnRightToggle = new Button();
            btnBottomToggle = new Button();
            spltLeft = new Splitter();
            btnTopToggle = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newSceneToolStripMenuItem = new ToolStripMenuItem();
            openModelsToolStripMenuItem = new ToolStripMenuItem();
            openAnimationsToolStripMenuItem = new ToolStripMenuItem();
            btnOpenClose = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openMovesetToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            btnUndo = new ToolStripMenuItem();
            btnRedo = new ToolStripMenuItem();
            takeScreenshotToolStripMenuItem = new ToolStripMenuItem();
            btnExportToImgNoTransparency = new ToolStripMenuItem();
            btnExportToImgWithTransparency = new ToolStripMenuItem();
            btnExportToAnimatedGIF = new ToolStripMenuItem();
            saveLocationToolStripMenuItem = new ToolStripMenuItem();
            ScreenCapBgLocText = new ToolStripMenuItem();
            imageFormatToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            editorsToolStripMenuItem = new ToolStripMenuItem();
            showTop = new ToolStripMenuItem();
            showLeft = new ToolStripMenuItem();
            showBottom = new ToolStripMenuItem();
            showRight = new ToolStripMenuItem();
            detachViewerToolStripMenuItem = new ToolStripMenuItem();
            viewportToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            setColorToolStripMenuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            displaySettingToolStripMenuItem = new ToolStripMenuItem();
            stretchToolStripMenuItem1 = new ToolStripMenuItem();
            centerToolStripMenuItem1 = new ToolStripMenuItem();
            resizeToolStripMenuItem1 = new ToolStripMenuItem();
            editControlToolStripMenuItem = new ToolStripMenuItem();
            scaleToolStripMenuItem = new ToolStripMenuItem();
            SLocalToolStripMenuItem = new ToolStripMenuItem();
            SWorldToolStripMenuItem = new ToolStripMenuItem();
            SCameraToolStripMenuItem = new ToolStripMenuItem();
            rotationToolStripMenuItem = new ToolStripMenuItem();
            RLocalToolStripMenuItem = new ToolStripMenuItem();
            RWorldToolStripMenuItem = new ToolStripMenuItem();
            RCameraToolStripMenuItem = new ToolStripMenuItem();
            translationToolStripMenuItem = new ToolStripMenuItem();
            TLocalToolStripMenuItem = new ToolStripMenuItem();
            TWorldToolStripMenuItem = new ToolStripMenuItem();
            TCameraToolStripMenuItem = new ToolStripMenuItem();
            afterRotationToolStripMenuItem = new ToolStripMenuItem();
            projectionToolStripMenuItem = new ToolStripMenuItem();
            perspectiveToolStripMenuItem = new ToolStripMenuItem();
            orthographicToolStripMenuItem = new ToolStripMenuItem();
            frontToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            leftToolStripMenuItem = new ToolStripMenuItem();
            rightToolStripMenuItem = new ToolStripMenuItem();
            topToolStripMenuItem = new ToolStripMenuItem();
            bottomToolStripMenuItem = new ToolStripMenuItem();
            toggleFloor = new ToolStripMenuItem();
            resetCameraToolStripMenuItem = new ToolStripMenuItem();
            showCameraCoordinatesToolStripMenuItem = new ToolStripMenuItem();
            firstPersonCameraToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            newViewportLeftToolStripMenuItem = new ToolStripMenuItem();
            newViewportAboveToolStripMenuItem = new ToolStripMenuItem();
            removeCurrentViewportToolStripMenuItem = new ToolStripMenuItem();
            modelToolStripMenuItem = new ToolStripMenuItem();
            toggleBones = new ToolStripMenuItem();
            togglePolygons = new ToolStripMenuItem();
            toggleVertices = new ToolStripMenuItem();
            toggleCollisions = new ToolStripMenuItem();
            wireframeToolStripMenuItem = new ToolStripMenuItem();
            toggleNormals = new ToolStripMenuItem();
            boundingBoxToolStripMenuItem = new ToolStripMenuItem();
            chkBBModels = new ToolStripMenuItem();
            chkBBObjects = new ToolStripMenuItem();
            chkBBVisBones = new ToolStripMenuItem();
            shadersToolStripMenuItem = new ToolStripMenuItem();
            chkBillboardBones = new ToolStripMenuItem();
            toggleMetals = new ToolStripMenuItem();
            fileTypesToolStripMenuItem = new ToolStripMenuItem();
            playToolStripMenuItem = new ToolStripMenuItem();
            playCHR0ToolStripMenuItem = new ToolStripMenuItem();
            playSRT0ToolStripMenuItem = new ToolStripMenuItem();
            playSHP0ToolStripMenuItem = new ToolStripMenuItem();
            playPAT0ToolStripMenuItem = new ToolStripMenuItem();
            playVIS0ToolStripMenuItem = new ToolStripMenuItem();
            playCLR0ToolStripMenuItem = new ToolStripMenuItem();
            playSCN0ToolStripMenuItem = new ToolStripMenuItem();
            sCN0ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            interpolationEditorToolStripMenuItem = new ToolStripMenuItem();
            selectedAnimationToolStripMenuItem = new ToolStripMenuItem();
            portToolStripMenuItem = new ToolStripMenuItem();
            mergeToolStripMenuItem = new ToolStripMenuItem();
            appendToolStripMenuItem = new ToolStripMenuItem();
            resizeToolStripMenuItem = new ToolStripMenuItem();
            interpolationToolStripMenuItem = new ToolStripMenuItem();
            averageAllStartEndTangentsToolStripMenuItem = new ToolStripMenuItem();
            averageboneStartendTangentsToolStripMenuItem = new ToolStripMenuItem();
            liveTextureFolderToolStripMenuItem = new ToolStripMenuItem();
            LiveTextureFolderPath = new ToolStripMenuItem();
            EnableLiveTextureFolder = new ToolStripMenuItem();
            btnWeightEditor = new ToolStripMenuItem();
            btnVertexEditor = new ToolStripMenuItem();
            targetModelToolStripMenuItem = new ToolStripMenuItem();
            chkEditAll = new ToolStripMenuItem();
            hideFromSceneToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            hideAllOtherModelsToolStripMenuItem = new ToolStripMenuItem();
            deleteAllOtherModelsToolStripMenuItem = new ToolStripMenuItem();
            chkExternalAnims = new ToolStripMenuItem();
            chkBRRESAnims = new ToolStripMenuItem();
            chkNonBRRESAnims = new ToolStripMenuItem();
            syncKinectToolStripMenuItem = new ToolStripMenuItem();
            notYetImplementedToolStripMenuItem = new ToolStripMenuItem();
            startTrackingToolStripMenuItem = new ToolStripMenuItem();
            models = new ComboBox();
            controlPanel = new Panel();
            splitter1 = new Splitter();
            toolStrip1 = new ToolStrip();
            chkBones = new ToolStripButton();
            chkPolygons = new ToolStripButton();
            chkVertices = new ToolStripButton();
            chkCollisions = new ToolStripButton();
            dropdownOverlays = new ToolStripDropDownButton();
            chkAllOverlays = new ToolStripMenuItem();
            chkBoundaries = new ToolStripMenuItem();
            chkSpawns = new ToolStripMenuItem();
            chkItems = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            chkFloor = new ToolStripButton();
            button1 = new ToolStripButton();
            chkZoomExtents = new ToolStripButton();
            btnSaveCam = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            cboToolSelect = new ToolStripComboBox();
            panel2 = new Panel();
            spltRight = new Splitter();
            panel1 = new Panel();
            modelPanel = new ModelPanel();
            label1 = new Label();
            animEditors = new Panel();
            pnlPlayback = new ModelPlaybackPanel();
            animCtrlPnl = new Panel();
            vis0Editor = new VIS0Editor();
            pat0Editor = new PAT0Editor();
            shp0Editor = new SHP0Editor();
            srt0Editor = new SRT0Editor();
            chr0Editor = new CHR0Editor();
            scn0Editor = new SCN0Editor();
            clr0Editor = new CLR0Editor();
            weightEditor = new WeightEditor();
            vertexEditor = new VertexEditor();
            rightPanel = new RightPanel();
            leftPanel = new LeftPanel();
            menuStrip1.SuspendLayout();
            controlPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            animEditors.SuspendLayout();
            animCtrlPnl.SuspendLayout();
            SuspendLayout();
            // 
            // dlgColor
            // 
            dlgColor.AnyColor = true;
            dlgColor.FullOpen = true;
            // 
            // btnLeftToggle
            // 
            btnLeftToggle.Dock = DockStyle.Left;
            btnLeftToggle.Location = new System.Drawing.Point(174, 26);
            btnLeftToggle.Name = "btnLeftToggle";
            btnLeftToggle.Size = new System.Drawing.Size(15, 389);
            btnLeftToggle.TabIndex = 5;
            btnLeftToggle.TabStop = false;
            btnLeftToggle.Text = ">";
            btnLeftToggle.UseVisualStyleBackColor = false;
            btnLeftToggle.Click += new EventHandler(btnLeftToggle_Click);
            // 
            // btnRightToggle
            // 
            btnRightToggle.Dock = DockStyle.Right;
            btnRightToggle.Location = new System.Drawing.Point(586, 26);
            btnRightToggle.Name = "btnRightToggle";
            btnRightToggle.Size = new System.Drawing.Size(15, 389);
            btnRightToggle.TabIndex = 6;
            btnRightToggle.TabStop = false;
            btnRightToggle.Text = "<";
            btnRightToggle.UseVisualStyleBackColor = false;
            btnRightToggle.Click += new EventHandler(btnRightToggle_Click);
            // 
            // btnBottomToggle
            // 
            btnBottomToggle.Dock = DockStyle.Bottom;
            btnBottomToggle.Location = new System.Drawing.Point(189, 400);
            btnBottomToggle.Name = "btnBottomToggle";
            btnBottomToggle.Size = new System.Drawing.Size(397, 15);
            btnBottomToggle.TabIndex = 8;
            btnBottomToggle.TabStop = false;
            btnBottomToggle.UseVisualStyleBackColor = false;
            btnBottomToggle.Click += new EventHandler(btnBottomToggle_Click);
            // 
            // spltLeft
            // 
            spltLeft.BackColor = Drawing.SystemColors.Control;
            spltLeft.Location = new System.Drawing.Point(170, 26);
            spltLeft.Name = "spltLeft";
            spltLeft.Size = new System.Drawing.Size(4, 389);
            spltLeft.TabIndex = 9;
            spltLeft.TabStop = false;
            spltLeft.Visible = false;
            // 
            // btnTopToggle
            // 
            btnTopToggle.Dock = DockStyle.Top;
            btnTopToggle.Location = new System.Drawing.Point(189, 26);
            btnTopToggle.Name = "btnTopToggle";
            btnTopToggle.Size = new System.Drawing.Size(397, 15);
            btnTopToggle.TabIndex = 11;
            btnTopToggle.TabStop = false;
            btnTopToggle.UseVisualStyleBackColor = false;
            btnTopToggle.Click += new EventHandler(btnTopToggle_Click);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Drawing.SystemColors.Control;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[]
            {
                fileToolStripMenuItem,
                editToolStripMenuItem,
                viewToolStripMenuItem1,
                toolsToolStripMenuItem,
                targetModelToolStripMenuItem
            });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(289, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                newSceneToolStripMenuItem,
                openModelsToolStripMenuItem,
                openAnimationsToolStripMenuItem,
                openMovesetToolStripMenuItem,
                closeToolStripMenuItem
            });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newSceneToolStripMenuItem
            // 
            newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            newSceneToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newSceneToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            newSceneToolStripMenuItem.Text = "New Scene";
            newSceneToolStripMenuItem.Click += new EventHandler(newSceneToolStripMenuItem_Click);
            // 
            // openModelsToolStripMenuItem
            // 
            openModelsToolStripMenuItem.Name = "openModelsToolStripMenuItem";
            openModelsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            openModelsToolStripMenuItem.Text = "Load Models";
            openModelsToolStripMenuItem.Click += new EventHandler(openFileToolStripMenuItem_Click);
            // 
            // openAnimationsToolStripMenuItem
            // 
            openAnimationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                btnOpenClose,
                saveToolStripMenuItem,
                saveAsToolStripMenuItem
            });
            openAnimationsToolStripMenuItem.Name = "openAnimationsToolStripMenuItem";
            openAnimationsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            openAnimationsToolStripMenuItem.Text = "Animations";
            // 
            // btnOpenClose
            // 
            btnOpenClose.Name = "btnOpenClose";
            btnOpenClose.ShortcutKeys = Keys.Control | Keys.O;
            btnOpenClose.Size = new System.Drawing.Size(186, 22);
            btnOpenClose.Text = "Load";
            btnOpenClose.Click += new EventHandler(btnLoadAnimations_Click);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            saveToolStripMenuItem.Text = "Save ";
            saveToolStripMenuItem.Click += new EventHandler(btnSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift
                                                                | Keys.S;
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += new EventHandler(btnSaveAs_Click);
            // 
            // openMovesetToolStripMenuItem
            // 
            openMovesetToolStripMenuItem.Name = "openMovesetToolStripMenuItem";
            openMovesetToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            openMovesetToolStripMenuItem.Text = "Load Moveset";
            openMovesetToolStripMenuItem.Visible = false;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            closeToolStripMenuItem.Text = "Close Window";
            closeToolStripMenuItem.Click += new EventHandler(closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                btnUndo,
                btnRedo,
                takeScreenshotToolStripMenuItem,
                settingsToolStripMenuItem
            });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            editToolStripMenuItem.Text = "Options";
            // 
            // btnUndo
            // 
            btnUndo.Enabled = false;
            btnUndo.Name = "btnUndo";
            btnUndo.ShortcutKeys = Keys.Control | Keys.Z;
            btnUndo.Size = new System.Drawing.Size(159, 22);
            btnUndo.Text = "Undo";
            btnUndo.Click += new EventHandler(btnUndo_Click);
            // 
            // btnRedo
            // 
            btnRedo.Enabled = false;
            btnRedo.Name = "btnRedo";
            btnRedo.ShortcutKeys = Keys.Control | Keys.Y;
            btnRedo.Size = new System.Drawing.Size(159, 22);
            btnRedo.Text = "Redo";
            btnRedo.Click += new EventHandler(btnRedo_Click);
            // 
            // takeScreenshotToolStripMenuItem
            // 
            takeScreenshotToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                btnExportToImgNoTransparency,
                btnExportToImgWithTransparency,
                btnExportToAnimatedGIF,
                saveLocationToolStripMenuItem,
                imageFormatToolStripMenuItem
            });
            takeScreenshotToolStripMenuItem.Name = "takeScreenshotToolStripMenuItem";
            takeScreenshotToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            takeScreenshotToolStripMenuItem.Text = "Take Screenshot";
            // 
            // btnExportToImgNoTransparency
            // 
            btnExportToImgNoTransparency.Name = "btnExportToImgNoTransparency";
            btnExportToImgNoTransparency.ShortcutKeyDisplayString = "Ctrl+Shift+I";
            btnExportToImgNoTransparency.Size = new System.Drawing.Size(291, 22);
            btnExportToImgNoTransparency.Text = "With Background";
            btnExportToImgNoTransparency.Click += new EventHandler(btnExportToImgNoTransparency_Click);
            // 
            // btnExportToImgWithTransparency
            // 
            btnExportToImgWithTransparency.Name = "btnExportToImgWithTransparency";
            btnExportToImgWithTransparency.ShortcutKeyDisplayString = "Ctrl+Alt+I";
            btnExportToImgWithTransparency.Size = new System.Drawing.Size(291, 22);
            btnExportToImgWithTransparency.Text = "With Transparent Background";
            btnExportToImgWithTransparency.Click += new EventHandler(btnExportToImgWithTransparency_Click);
            // 
            // btnExportToAnimatedGIF
            // 
            btnExportToAnimatedGIF.Name = "btnExportToAnimatedGIF";
            btnExportToAnimatedGIF.Size = new System.Drawing.Size(291, 22);
            btnExportToAnimatedGIF.Text = "To Animated GIF";
            btnExportToAnimatedGIF.Click += new EventHandler(btnExportToAnimatedGIF_Click);
            // 
            // saveLocationToolStripMenuItem
            // 
            saveLocationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                ScreenCapBgLocText
            });
            saveLocationToolStripMenuItem.Name = "saveLocationToolStripMenuItem";
            saveLocationToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            saveLocationToolStripMenuItem.Text = "Save Location";
            // 
            // ScreenCapBgLocText
            // 
            ScreenCapBgLocText.Name = "ScreenCapBgLocText";
            ScreenCapBgLocText.Size = new System.Drawing.Size(110, 22);
            ScreenCapBgLocText.Text = "<null>";
            ScreenCapBgLocText.Click += new EventHandler(ScreenCapBgLocText_Click);
            // 
            // imageFormatToolStripMenuItem
            // 
            imageFormatToolStripMenuItem.Name = "imageFormatToolStripMenuItem";
            imageFormatToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            imageFormatToolStripMenuItem.Text = "Image Format: PNG";
            imageFormatToolStripMenuItem.Click += new EventHandler(imageFormatToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += new EventHandler(settingsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[]
            {
                editorsToolStripMenuItem,
                viewportToolStripMenuItem,
                modelToolStripMenuItem,
                fileTypesToolStripMenuItem,
                helpToolStripMenuItem
            });
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem1.Text = "View";
            // 
            // editorsToolStripMenuItem
            // 
            editorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                showTop,
                showLeft,
                showBottom,
                showRight,
                detachViewerToolStripMenuItem
            });
            editorsToolStripMenuItem.Name = "editorsToolStripMenuItem";
            editorsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            editorsToolStripMenuItem.Text = "Panels";
            // 
            // showTop
            // 
            showTop.CheckOnClick = true;
            showTop.Name = "showTop";
            showTop.Size = new System.Drawing.Size(186, 22);
            showTop.Text = "Menu Bar";
            showTop.CheckedChanged += new EventHandler(showTop_CheckedChanged);
            // 
            // showLeft
            // 
            showLeft.CheckOnClick = true;
            showLeft.Name = "showLeft";
            showLeft.Size = new System.Drawing.Size(186, 22);
            showLeft.Text = "Left Panel";
            showLeft.CheckedChanged += new EventHandler(showLeft_CheckedChanged);
            // 
            // showBottom
            // 
            showBottom.CheckOnClick = true;
            showBottom.Name = "showBottom";
            showBottom.Size = new System.Drawing.Size(186, 22);
            showBottom.Text = "Animation Panel";
            showBottom.CheckedChanged += new EventHandler(showBottom_CheckedChanged);
            // 
            // showRight
            // 
            showRight.CheckOnClick = true;
            showRight.Name = "showRight";
            showRight.Size = new System.Drawing.Size(186, 22);
            showRight.Text = "Right Panel";
            showRight.CheckedChanged += new EventHandler(showRight_CheckedChanged);
            // 
            // detachViewerToolStripMenuItem
            // 
            detachViewerToolStripMenuItem.Name = "detachViewerToolStripMenuItem";
            detachViewerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            detachViewerToolStripMenuItem.Text = "Detach Model Viewer";
            detachViewerToolStripMenuItem.Click += new EventHandler(detachViewerToolStripMenuItem_Click);
            // 
            // viewportToolStripMenuItem
            // 
            viewportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                backgroundToolStripMenuItem,
                editControlToolStripMenuItem,
                projectionToolStripMenuItem,
                toggleFloor,
                resetCameraToolStripMenuItem,
                showCameraCoordinatesToolStripMenuItem,
                firstPersonCameraToolStripMenuItem,
                newToolStripMenuItem,
                removeCurrentViewportToolStripMenuItem
            });
            viewportToolStripMenuItem.Name = "viewportToolStripMenuItem";
            viewportToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            viewportToolStripMenuItem.Text = "Viewport";
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                setColorToolStripMenuItem,
                loadImageToolStripMenuItem,
                displaySettingToolStripMenuItem
            });
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            backgroundToolStripMenuItem.Text = "Background";
            // 
            // setColorToolStripMenuItem
            // 
            setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            setColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            setColorToolStripMenuItem.Text = "Set Color";
            setColorToolStripMenuItem.Click += new EventHandler(setColorToolStripMenuItem_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            loadImageToolStripMenuItem.Text = "Load Image";
            loadImageToolStripMenuItem.Click += new EventHandler(loadImageToolStripMenuItem_Click);
            // 
            // displaySettingToolStripMenuItem
            // 
            displaySettingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                stretchToolStripMenuItem1,
                centerToolStripMenuItem1,
                resizeToolStripMenuItem1
            });
            displaySettingToolStripMenuItem.Name = "displaySettingToolStripMenuItem";
            displaySettingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            displaySettingToolStripMenuItem.Text = "Display Setting";
            // 
            // stretchToolStripMenuItem1
            // 
            stretchToolStripMenuItem1.Checked = true;
            stretchToolStripMenuItem1.CheckOnClick = true;
            stretchToolStripMenuItem1.CheckState = CheckState.Checked;
            stretchToolStripMenuItem1.Name = "stretchToolStripMenuItem1";
            stretchToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            stretchToolStripMenuItem1.Text = "Stretch";
            stretchToolStripMenuItem1.Click += new EventHandler(stretchToolStripMenuItem1_Click);
            // 
            // centerToolStripMenuItem1
            // 
            centerToolStripMenuItem1.CheckOnClick = true;
            centerToolStripMenuItem1.Name = "centerToolStripMenuItem1";
            centerToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            centerToolStripMenuItem1.Text = "Center";
            centerToolStripMenuItem1.Click += new EventHandler(centerToolStripMenuItem1_Click);
            // 
            // resizeToolStripMenuItem1
            // 
            resizeToolStripMenuItem1.CheckOnClick = true;
            resizeToolStripMenuItem1.Name = "resizeToolStripMenuItem1";
            resizeToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            resizeToolStripMenuItem1.Text = "Resize";
            resizeToolStripMenuItem1.Click += new EventHandler(resizeToolStripMenuItem1_Click);
            // 
            // editControlToolStripMenuItem
            // 
            editControlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                scaleToolStripMenuItem,
                rotationToolStripMenuItem,
                translationToolStripMenuItem
            });
            editControlToolStripMenuItem.Name = "editControlToolStripMenuItem";
            editControlToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            editControlToolStripMenuItem.Text = "Transform Control";
            // 
            // scaleToolStripMenuItem
            // 
            scaleToolStripMenuItem.CheckOnClick = true;
            scaleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                SLocalToolStripMenuItem,
                SWorldToolStripMenuItem,
                SCameraToolStripMenuItem
            });
            scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            scaleToolStripMenuItem.ShortcutKeyDisplayString = "E Key";
            scaleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            scaleToolStripMenuItem.Text = "Scale";
            scaleToolStripMenuItem.Click += new EventHandler(scaleToolStripMenuItem_Click);
            // 
            // SLocalToolStripMenuItem
            // 
            SLocalToolStripMenuItem.Checked = true;
            SLocalToolStripMenuItem.CheckState = CheckState.Checked;
            SLocalToolStripMenuItem.Name = "SLocalToolStripMenuItem";
            SLocalToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            SLocalToolStripMenuItem.Text = "Local";
            SLocalToolStripMenuItem.Click += new EventHandler(SLocalToolStripMenuItem_Click);
            // 
            // SWorldToolStripMenuItem
            // 
            SWorldToolStripMenuItem.Name = "SWorldToolStripMenuItem";
            SWorldToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            SWorldToolStripMenuItem.Text = "World";
            SWorldToolStripMenuItem.Click += new EventHandler(SWorldToolStripMenuItem_Click);
            // 
            // SCameraToolStripMenuItem
            // 
            SCameraToolStripMenuItem.Enabled = false;
            SCameraToolStripMenuItem.Name = "SCameraToolStripMenuItem";
            SCameraToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            SCameraToolStripMenuItem.Text = "Screen";
            SCameraToolStripMenuItem.Visible = false;
            SCameraToolStripMenuItem.Click += new EventHandler(SCameraToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            rotationToolStripMenuItem.Checked = true;
            rotationToolStripMenuItem.CheckOnClick = true;
            rotationToolStripMenuItem.CheckState = CheckState.Checked;
            rotationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                RLocalToolStripMenuItem,
                RWorldToolStripMenuItem,
                RCameraToolStripMenuItem
            });
            rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            rotationToolStripMenuItem.ShortcutKeyDisplayString = "R Key";
            rotationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            rotationToolStripMenuItem.Text = "Rotation";
            rotationToolStripMenuItem.Click += new EventHandler(rotationToolStripMenuItem_Click);
            // 
            // RLocalToolStripMenuItem
            // 
            RLocalToolStripMenuItem.Checked = true;
            RLocalToolStripMenuItem.CheckState = CheckState.Checked;
            RLocalToolStripMenuItem.Name = "RLocalToolStripMenuItem";
            RLocalToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            RLocalToolStripMenuItem.Text = "Local";
            RLocalToolStripMenuItem.Click += new EventHandler(RLocalToolStripMenuItem_Click);
            // 
            // RWorldToolStripMenuItem
            // 
            RWorldToolStripMenuItem.Name = "RWorldToolStripMenuItem";
            RWorldToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            RWorldToolStripMenuItem.Text = "World";
            RWorldToolStripMenuItem.Click += new EventHandler(RWorldToolStripMenuItem_Click);
            // 
            // RCameraToolStripMenuItem
            // 
            RCameraToolStripMenuItem.Enabled = false;
            RCameraToolStripMenuItem.Name = "RCameraToolStripMenuItem";
            RCameraToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            RCameraToolStripMenuItem.Text = "Screen";
            RCameraToolStripMenuItem.Visible = false;
            RCameraToolStripMenuItem.Click += new EventHandler(RCameraToolStripMenuItem_Click);
            // 
            // translationToolStripMenuItem
            // 
            translationToolStripMenuItem.CheckOnClick = true;
            translationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                TLocalToolStripMenuItem,
                TWorldToolStripMenuItem,
                TCameraToolStripMenuItem,
                afterRotationToolStripMenuItem
            });
            translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            translationToolStripMenuItem.ShortcutKeyDisplayString = "T Key";
            translationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            translationToolStripMenuItem.Text = "Translation";
            translationToolStripMenuItem.Click += new EventHandler(translationToolStripMenuItem_Click);
            // 
            // TLocalToolStripMenuItem
            // 
            TLocalToolStripMenuItem.Checked = true;
            TLocalToolStripMenuItem.CheckState = CheckState.Checked;
            TLocalToolStripMenuItem.Name = "TLocalToolStripMenuItem";
            TLocalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            TLocalToolStripMenuItem.Text = "Local";
            TLocalToolStripMenuItem.Click += new EventHandler(TLocalToolStripMenuItem_Click);
            // 
            // TWorldToolStripMenuItem
            // 
            TWorldToolStripMenuItem.Name = "TWorldToolStripMenuItem";
            TWorldToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            TWorldToolStripMenuItem.Text = "World";
            TWorldToolStripMenuItem.Click += new EventHandler(TWorldToolStripMenuItem_Click);
            // 
            // TCameraToolStripMenuItem
            // 
            TCameraToolStripMenuItem.Enabled = false;
            TCameraToolStripMenuItem.Name = "TCameraToolStripMenuItem";
            TCameraToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            TCameraToolStripMenuItem.Text = "Screen";
            TCameraToolStripMenuItem.Visible = false;
            TCameraToolStripMenuItem.Click += new EventHandler(TCameraToolStripMenuItem_Click);
            // 
            // afterRotationToolStripMenuItem
            // 
            afterRotationToolStripMenuItem.Name = "afterRotationToolStripMenuItem";
            afterRotationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            afterRotationToolStripMenuItem.Text = "After Rotation";
            afterRotationToolStripMenuItem.Click += new EventHandler(afterRotationToolStripMenuItem_Click);
            // 
            // projectionToolStripMenuItem
            // 
            projectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                perspectiveToolStripMenuItem,
                orthographicToolStripMenuItem,
                frontToolStripMenuItem,
                backToolStripMenuItem,
                leftToolStripMenuItem,
                rightToolStripMenuItem,
                topToolStripMenuItem,
                bottomToolStripMenuItem
            });
            projectionToolStripMenuItem.Name = "projectionToolStripMenuItem";
            projectionToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            projectionToolStripMenuItem.Text = "Projection";
            // 
            // perspectiveToolStripMenuItem
            // 
            perspectiveToolStripMenuItem.Checked = true;
            perspectiveToolStripMenuItem.CheckState = CheckState.Checked;
            perspectiveToolStripMenuItem.Name = "perspectiveToolStripMenuItem";
            perspectiveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            perspectiveToolStripMenuItem.Text = "Perspective";
            perspectiveToolStripMenuItem.Click += new EventHandler(perspectiveToolStripMenuItem_Click);
            // 
            // orthographicToolStripMenuItem
            // 
            orthographicToolStripMenuItem.Name = "orthographicToolStripMenuItem";
            orthographicToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            orthographicToolStripMenuItem.Text = "Orthographic";
            orthographicToolStripMenuItem.Click += new EventHandler(orthographicToolStripMenuItem_Click);
            // 
            // frontToolStripMenuItem
            // 
            frontToolStripMenuItem.Name = "frontToolStripMenuItem";
            frontToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            frontToolStripMenuItem.Text = "Front";
            frontToolStripMenuItem.Click += new EventHandler(frontToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += new EventHandler(backToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            leftToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            leftToolStripMenuItem.Text = "Left";
            leftToolStripMenuItem.Click += new EventHandler(leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            rightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            rightToolStripMenuItem.Text = "Right";
            rightToolStripMenuItem.Click += new EventHandler(rightToolStripMenuItem_Click);
            // 
            // topToolStripMenuItem
            // 
            topToolStripMenuItem.Name = "topToolStripMenuItem";
            topToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            topToolStripMenuItem.Text = "Top";
            topToolStripMenuItem.Click += new EventHandler(topToolStripMenuItem_Click);
            // 
            // bottomToolStripMenuItem
            // 
            bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            bottomToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            bottomToolStripMenuItem.Text = "Bottom";
            bottomToolStripMenuItem.Click += new EventHandler(bottomToolStripMenuItem_Click);
            // 
            // toggleFloor
            // 
            toggleFloor.Name = "toggleFloor";
            toggleFloor.ShortcutKeyDisplayString = "F Key";
            toggleFloor.Size = new System.Drawing.Size(214, 22);
            toggleFloor.Text = "Floor";
            toggleFloor.Click += new EventHandler(toggleRenderFloor_Event);
            // 
            // resetCameraToolStripMenuItem
            // 
            resetCameraToolStripMenuItem.Name = "resetCameraToolStripMenuItem";
            resetCameraToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            resetCameraToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            resetCameraToolStripMenuItem.Text = "Reset Camera";
            resetCameraToolStripMenuItem.Click += new EventHandler(resetCameraToolStripMenuItem_Click_1);
            // 
            // showCameraCoordinatesToolStripMenuItem
            // 
            showCameraCoordinatesToolStripMenuItem.Name = "showCameraCoordinatesToolStripMenuItem";
            showCameraCoordinatesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            showCameraCoordinatesToolStripMenuItem.Text = "Show Camera Coordinates";
            showCameraCoordinatesToolStripMenuItem.Click +=
                new EventHandler(showCameraCoordinatesToolStripMenuItem_Click);
            // 
            // firstPersonCameraToolStripMenuItem
            // 
            firstPersonCameraToolStripMenuItem.Name = "firstPersonCameraToolStripMenuItem";
            firstPersonCameraToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            firstPersonCameraToolStripMenuItem.Text = "1st Person SCN0 Camera";
            firstPersonCameraToolStripMenuItem.Click += new EventHandler(firstPersonCameraToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                newViewportLeftToolStripMenuItem,
                newViewportAboveToolStripMenuItem
            });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            newToolStripMenuItem.Text = "Add New Viewport";
            // 
            // newViewportLeftToolStripMenuItem
            // 
            newViewportLeftToolStripMenuItem.Name = "newViewportLeftToolStripMenuItem";
            newViewportLeftToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            newViewportLeftToolStripMenuItem.Text = "To the left";
            newViewportLeftToolStripMenuItem.Click += new EventHandler(leftToolStripMenuItem1_Click);
            // 
            // newViewportAboveToolStripMenuItem
            // 
            newViewportAboveToolStripMenuItem.Name = "newViewportAboveToolStripMenuItem";
            newViewportAboveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            newViewportAboveToolStripMenuItem.Text = "Above";
            newViewportAboveToolStripMenuItem.Click += new EventHandler(topToolStripMenuItem1_Click);
            // 
            // removeCurrentViewportToolStripMenuItem
            // 
            removeCurrentViewportToolStripMenuItem.Name = "removeCurrentViewportToolStripMenuItem";
            removeCurrentViewportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            removeCurrentViewportToolStripMenuItem.Text = "Remove Current Viewport";
            removeCurrentViewportToolStripMenuItem.Click +=
                new EventHandler(removeCurrentViewportToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            modelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                toggleBones,
                togglePolygons,
                toggleVertices,
                toggleMetals,
                toggleCollisions,
                wireframeToolStripMenuItem,
                toggleNormals,
                boundingBoxToolStripMenuItem,
                shadersToolStripMenuItem,
                chkBillboardBones
            });
            modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            modelToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            modelToolStripMenuItem.Text = "Model";
            // 
            // toggleBones
            // 
            toggleBones.Checked = true;
            toggleBones.CheckState = CheckState.Checked;
            toggleBones.Name = "toggleBones";
            toggleBones.ShortcutKeyDisplayString = "B Key";
            toggleBones.Size = new System.Drawing.Size(159, 22);
            toggleBones.Text = "Bones";
            toggleBones.Click += new EventHandler(toggleRenderBones_Event);
            // 
            // togglePolygons
            // 
            togglePolygons.Checked = true;
            togglePolygons.CheckState = CheckState.Checked;
            togglePolygons.Name = "togglePolygons";
            togglePolygons.ShortcutKeyDisplayString = "P Key";
            togglePolygons.Size = new System.Drawing.Size(159, 22);
            togglePolygons.Text = "Polygons";
            togglePolygons.Click += new EventHandler(toggleRenderPolygons_Event);
            // 
            // toggleVertices
            // 
            toggleVertices.Checked = true;
            toggleVertices.CheckState = CheckState.Checked;
            toggleVertices.Name = "toggleVertices";
            toggleVertices.ShortcutKeyDisplayString = "V Key";
            toggleVertices.Size = new System.Drawing.Size(159, 22);
            toggleVertices.Text = "Vertices";
            toggleVertices.Click += new EventHandler(toggleRenderVertices_Event);
            // 
            // toggleCollisions
            // 
            toggleCollisions.Checked = true;
            toggleCollisions.CheckState = CheckState.Checked;
            toggleCollisions.Name = "toggleCollisions";
            toggleCollisions.Size = new System.Drawing.Size(159, 22);
            toggleCollisions.Text = "Collisions";
            toggleCollisions.Click += new EventHandler(toggleRenderCollisions_Event);
            // 
            // wireframeToolStripMenuItem
            // 
            wireframeToolStripMenuItem.Name = "wireframeToolStripMenuItem";
            wireframeToolStripMenuItem.ShortcutKeyDisplayString = "";
            wireframeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            wireframeToolStripMenuItem.Text = "Wireframe";
            wireframeToolStripMenuItem.Click += new EventHandler(wireframeToolStripMenuItem_Click);
            // 
            // toggleNormals
            // 
            toggleNormals.Name = "toggleNormals";
            toggleNormals.Size = new System.Drawing.Size(159, 22);
            toggleNormals.Text = "Normals";
            toggleNormals.Click += new EventHandler(toggleNormals_Click);
            // 
            // boundingBoxToolStripMenuItem
            // 
            boundingBoxToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                chkBBModels,
                chkBBObjects,
                chkBBVisBones
            });
            boundingBoxToolStripMenuItem.Name = "boundingBoxToolStripMenuItem";
            boundingBoxToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            boundingBoxToolStripMenuItem.Text = "Bounding Box";
            // 
            // chkBBModels
            // 
            chkBBModels.Name = "chkBBModels";
            chkBBModels.Size = new System.Drawing.Size(153, 22);
            chkBBModels.Text = "Models";
            chkBBModels.Click += new EventHandler(modelToolStripMenuItem1_Click);
            // 
            // chkBBObjects
            // 
            chkBBObjects.Name = "chkBBObjects";
            chkBBObjects.Size = new System.Drawing.Size(153, 22);
            chkBBObjects.Text = "Objects";
            chkBBObjects.Click += new EventHandler(objectsToolStripMenuItem_Click);
            // 
            // chkBBVisBones
            // 
            chkBBVisBones.Name = "chkBBVisBones";
            chkBBVisBones.Size = new System.Drawing.Size(153, 22);
            chkBBVisBones.Text = "Visibility Bones";
            chkBBVisBones.Click += new EventHandler(visibilityBonesToolStripMenuItem_Click);
            // 
            // shadersToolStripMenuItem
            // 
            shadersToolStripMenuItem.Checked = true;
            shadersToolStripMenuItem.CheckState = CheckState.Checked;
            shadersToolStripMenuItem.Name = "shadersToolStripMenuItem";
            shadersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            shadersToolStripMenuItem.Text = "Shaders";
            shadersToolStripMenuItem.Click += new EventHandler(shadersToolStripMenuItem_Click);
            // 
            // chkBillboardBones
            // 
            chkBillboardBones.Checked = true;
            chkBillboardBones.CheckState = CheckState.Checked;
            chkBillboardBones.Name = "chkBillboardBones";
            chkBillboardBones.Size = new System.Drawing.Size(159, 22);
            chkBillboardBones.Text = "Billboard Bones";
            chkBillboardBones.Click += new EventHandler(chkBillboardBones_Click);
            // 
            // toggleMetals
            // 
            toggleMetals.Name = "toggleMetals";
            toggleMetals.Size = new System.Drawing.Size(159, 22);
            toggleMetals.Text = "Metals";
            toggleMetals.ShortcutKeyDisplayString = "M Key";
            toggleMetals.Click += new EventHandler(toggleMetals_Event);
            // 
            // fileTypesToolStripMenuItem
            // 
            fileTypesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                playToolStripMenuItem,
                sCN0ToolStripMenuItem
            });
            fileTypesToolStripMenuItem.Name = "fileTypesToolStripMenuItem";
            fileTypesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            fileTypesToolStripMenuItem.Text = "Animations";
            // 
            // playToolStripMenuItem
            // 
            playToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                playCHR0ToolStripMenuItem,
                playSRT0ToolStripMenuItem,
                playSHP0ToolStripMenuItem,
                playPAT0ToolStripMenuItem,
                playVIS0ToolStripMenuItem,
                playCLR0ToolStripMenuItem,
                playSCN0ToolStripMenuItem
            });
            playToolStripMenuItem.Name = "playToolStripMenuItem";
            playToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            playToolStripMenuItem.Text = "Play";
            // 
            // playCHR0ToolStripMenuItem
            // 
            playCHR0ToolStripMenuItem.Checked = true;
            playCHR0ToolStripMenuItem.CheckOnClick = true;
            playCHR0ToolStripMenuItem.CheckState = CheckState.Checked;
            playCHR0ToolStripMenuItem.Name = "playCHR0ToolStripMenuItem";
            playCHR0ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            playCHR0ToolStripMenuItem.Text = "CHR0";
            playCHR0ToolStripMenuItem.Click += new EventHandler(playCHR0ToolStripMenuItem_Click);
            // 
            // playSRT0ToolStripMenuItem
            // 
            playSRT0ToolStripMenuItem.Checked = true;
            playSRT0ToolStripMenuItem.CheckOnClick = true;
            playSRT0ToolStripMenuItem.CheckState = CheckState.Checked;
            playSRT0ToolStripMenuItem.Name = "playSRT0ToolStripMenuItem";
            playSRT0ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            playSRT0ToolStripMenuItem.Text = "SRT0";
            playSRT0ToolStripMenuItem.Click += new EventHandler(playSRT0ToolStripMenuItem_Click);
            // 
            // playSHP0ToolStripMenuItem
            // 
            playSHP0ToolStripMenuItem.Checked = true;
            playSHP0ToolStripMenuItem.CheckOnClick = true;
            playSHP0ToolStripMenuItem.CheckState = CheckState.Checked;
            playSHP0ToolStripMenuItem.Name = "playSHP0ToolStripMenuItem";
            playSHP0ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            playSHP0ToolStripMenuItem.Text = "SHP0";
            playSHP0ToolStripMenuItem.Click += new EventHandler(playSHP0ToolStripMenuItem_Click);
            // 
            // playPAT0ToolStripMenuItem
            // 
            playPAT0ToolStripMenuItem.Checked = true;
            playPAT0ToolStripMenuItem.CheckOnClick = true;
            playPAT0ToolStripMenuItem.CheckState = CheckState.Checked;
            playPAT0ToolStripMenuItem.Name = "playPAT0ToolStripMenuItem";
            playPAT0ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            playPAT0ToolStripMenuItem.Text = "PAT0";
            playPAT0ToolStripMenuItem.Click += new EventHandler(playPAT0ToolStripMenuItem_Click);
            // 
            // playVIS0ToolStripMenuItem
            // 
            playVIS0ToolStripMenuItem.Checked = true;
            playVIS0ToolStripMenuItem.CheckOnClick = true;
            playVIS0ToolStripMenuItem.CheckState = CheckState.Checked;
            playVIS0ToolStripMenuItem.Name = "playVIS0ToolStripMenuItem";
            playVIS0ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            playVIS0ToolStripMenuItem.Text = "VIS0";
            playVIS0ToolStripMenuItem.Click += new EventHandler(playVIS0ToolStripMenuItem_Click);
            // 
            // playCLR0ToolStripMenuItem
            // 
            playCLR0ToolStripMenuItem.Checked = true;
            playCLR0ToolStripMenuItem.CheckState = CheckState.Checked;
            playCLR0ToolStripMenuItem.Name = "playCLR0ToolStripMenuItem";
            playCLR0ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            playCLR0ToolStripMenuItem.Text = "CLR0";
            playCLR0ToolStripMenuItem.Click += new EventHandler(playCLR0ToolStripMenuItem_Click);
            // 
            // playSCN0ToolStripMenuItem
            // 
            playSCN0ToolStripMenuItem.Checked = true;
            playSCN0ToolStripMenuItem.CheckState = CheckState.Checked;
            playSCN0ToolStripMenuItem.Name = "playSCN0ToolStripMenuItem";
            playSCN0ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            playSCN0ToolStripMenuItem.Text = "SCN0";
            playSCN0ToolStripMenuItem.Click += new EventHandler(playSCN0ToolStripMenuItem1_Click);
            // 
            // sCN0ToolStripMenuItem
            // 
            sCN0ToolStripMenuItem.Checked = true;
            sCN0ToolStripMenuItem.CheckState = CheckState.Checked;
            sCN0ToolStripMenuItem.Name = "sCN0ToolStripMenuItem";
            sCN0ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            sCN0ToolStripMenuItem.Text = "Show SCN0 Lights/Cameras";
            sCN0ToolStripMenuItem.Click += new EventHandler(sCN0ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += new EventHandler(helpToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                interpolationEditorToolStripMenuItem,
                selectedAnimationToolStripMenuItem,
                liveTextureFolderToolStripMenuItem,
                btnWeightEditor,
                btnVertexEditor
            });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // interpolationEditorToolStripMenuItem
            // 
            interpolationEditorToolStripMenuItem.Name = "interpolationEditorToolStripMenuItem";
            interpolationEditorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            interpolationEditorToolStripMenuItem.Text = "Interpolation Editor";
            interpolationEditorToolStripMenuItem.Click += new EventHandler(interpolationEditorToolStripMenuItem_Click);
            // 
            // selectedAnimationToolStripMenuItem
            // 
            selectedAnimationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                portToolStripMenuItem,
                mergeToolStripMenuItem,
                appendToolStripMenuItem,
                resizeToolStripMenuItem,
                interpolationToolStripMenuItem
            });
            selectedAnimationToolStripMenuItem.Enabled = false;
            selectedAnimationToolStripMenuItem.Name = "selectedAnimationToolStripMenuItem";
            selectedAnimationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            selectedAnimationToolStripMenuItem.Text = "Selected Animation";
            // 
            // portToolStripMenuItem
            // 
            portToolStripMenuItem.Enabled = false;
            portToolStripMenuItem.Name = "portToolStripMenuItem";
            portToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            portToolStripMenuItem.Text = "Port";
            portToolStripMenuItem.Click += new EventHandler(portToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            mergeToolStripMenuItem.Enabled = false;
            mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            mergeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            mergeToolStripMenuItem.Text = "Merge";
            mergeToolStripMenuItem.Click += new EventHandler(mergeToolStripMenuItem_Click);
            // 
            // appendToolStripMenuItem
            // 
            appendToolStripMenuItem.Enabled = false;
            appendToolStripMenuItem.Name = "appendToolStripMenuItem";
            appendToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            appendToolStripMenuItem.Text = "Append";
            appendToolStripMenuItem.Click += new EventHandler(appendToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            resizeToolStripMenuItem.Enabled = false;
            resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            resizeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            resizeToolStripMenuItem.Text = "Resize";
            resizeToolStripMenuItem.Click += new EventHandler(resizeToolStripMenuItem_Click);
            // 
            // interpolationToolStripMenuItem
            // 
            interpolationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                averageAllStartEndTangentsToolStripMenuItem,
                averageboneStartendTangentsToolStripMenuItem
            });
            interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            interpolationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            interpolationToolStripMenuItem.Text = "Interpolation";
            // 
            // averageAllStartEndTangentsToolStripMenuItem
            // 
            averageAllStartEndTangentsToolStripMenuItem.Name = "averageAllStartEndTangentsToolStripMenuItem";
            averageAllStartEndTangentsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            averageAllStartEndTangentsToolStripMenuItem.Text = "Average all start/end keyframes";
            averageAllStartEndTangentsToolStripMenuItem.Click +=
                new EventHandler(averageAllStartEndTangentsToolStripMenuItem_Click);
            // 
            // averageboneStartendTangentsToolStripMenuItem
            // 
            averageboneStartendTangentsToolStripMenuItem.Enabled = false;
            averageboneStartendTangentsToolStripMenuItem.Name = "averageboneStartendTangentsToolStripMenuItem";
            averageboneStartendTangentsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            averageboneStartendTangentsToolStripMenuItem.Text = "Average entry start/end keyframes";
            averageboneStartendTangentsToolStripMenuItem.Click +=
                new EventHandler(averageboneStartendTangentsToolStripMenuItem_Click);
            // 
            // liveTextureFolderToolStripMenuItem
            // 
            liveTextureFolderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                LiveTextureFolderPath,
                EnableLiveTextureFolder
            });
            liveTextureFolderToolStripMenuItem.Name = "liveTextureFolderToolStripMenuItem";
            liveTextureFolderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            liveTextureFolderToolStripMenuItem.Text = "Live Texture Folder";
            // 
            // LiveTextureFolderPath
            // 
            LiveTextureFolderPath.Name = "LiveTextureFolderPath";
            LiveTextureFolderPath.Size = new System.Drawing.Size(116, 22);
            LiveTextureFolderPath.Text = "<path>";
            LiveTextureFolderPath.Click += new EventHandler(LiveTextureFolderPath_Click);
            // 
            // EnableLiveTextureFolder
            // 
            EnableLiveTextureFolder.Name = "EnableLiveTextureFolder";
            EnableLiveTextureFolder.Size = new System.Drawing.Size(116, 22);
            EnableLiveTextureFolder.Text = "Enabled";
            EnableLiveTextureFolder.Click += new EventHandler(EnableLiveTextureFolder_Click);
            // 
            // btnWeightEditor
            // 
            btnWeightEditor.Name = "btnWeightEditor";
            btnWeightEditor.ShortcutKeyDisplayString = "9 Key";
            btnWeightEditor.Size = new System.Drawing.Size(181, 22);
            btnWeightEditor.Text = "Weight Editor";
            btnWeightEditor.Click += new EventHandler(btnWeightEditor_Click);
            // 
            // btnVertexEditor
            // 
            btnVertexEditor.Name = "btnVertexEditor";
            btnVertexEditor.ShortcutKeyDisplayString = "5 Key";
            btnVertexEditor.Size = new System.Drawing.Size(181, 22);
            btnVertexEditor.Text = "Vertex Editor";
            btnVertexEditor.Click += new EventHandler(btnVertexEditor_Click);
            // 
            // targetModelToolStripMenuItem
            // 
            targetModelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                chkEditAll,
                hideFromSceneToolStripMenuItem,
                deleteToolStripMenuItem,
                hideAllOtherModelsToolStripMenuItem,
                deleteAllOtherModelsToolStripMenuItem,
                chkExternalAnims,
                chkBRRESAnims,
                chkNonBRRESAnims
            });
            targetModelToolStripMenuItem.Name = "targetModelToolStripMenuItem";
            targetModelToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            targetModelToolStripMenuItem.Text = "Target Model:";
            // 
            // chkEditAll
            // 
            chkEditAll.Name = "chkEditAll";
            chkEditAll.Size = new System.Drawing.Size(244, 22);
            chkEditAll.Text = "Edit All";
            chkEditAll.Click += new EventHandler(chkEditAll_Click);
            // 
            // hideFromSceneToolStripMenuItem
            // 
            hideFromSceneToolStripMenuItem.Name = "hideFromSceneToolStripMenuItem";
            hideFromSceneToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            hideFromSceneToolStripMenuItem.Text = "Hide from scene";
            hideFromSceneToolStripMenuItem.Click += new EventHandler(hideFromSceneToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            deleteToolStripMenuItem.Text = "Delete from scene";
            deleteToolStripMenuItem.Click += new EventHandler(deleteToolStripMenuItem_Click);
            // 
            // hideAllOtherModelsToolStripMenuItem
            // 
            hideAllOtherModelsToolStripMenuItem.Name = "hideAllOtherModelsToolStripMenuItem";
            hideAllOtherModelsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            hideAllOtherModelsToolStripMenuItem.Text = "Hide all other models";
            hideAllOtherModelsToolStripMenuItem.Click += new EventHandler(hideAllOtherModelsToolStripMenuItem_Click);
            // 
            // deleteAllOtherModelsToolStripMenuItem
            // 
            deleteAllOtherModelsToolStripMenuItem.Name = "deleteAllOtherModelsToolStripMenuItem";
            deleteAllOtherModelsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            deleteAllOtherModelsToolStripMenuItem.Text = "Delete all other models";
            deleteAllOtherModelsToolStripMenuItem.Click +=
                new EventHandler(deleteAllOtherModelsToolStripMenuItem_Click);
            // 
            // chkExternalAnims
            // 
            chkExternalAnims.Checked = true;
            chkExternalAnims.CheckOnClick = true;
            chkExternalAnims.CheckState = CheckState.Checked;
            chkExternalAnims.Name = "chkExternalAnims";
            chkExternalAnims.Size = new System.Drawing.Size(244, 22);
            chkExternalAnims.Text = "Display external animations";
            chkExternalAnims.CheckedChanged += new EventHandler(UpdateAnimList_Event);
            // 
            // chkBRRESAnims
            // 
            chkBRRESAnims.Checked = true;
            chkBRRESAnims.CheckOnClick = true;
            chkBRRESAnims.CheckState = CheckState.Checked;
            chkBRRESAnims.Name = "chkBRRESAnims";
            chkBRRESAnims.Size = new System.Drawing.Size(244, 22);
            chkBRRESAnims.Text = "Display animations in BRRES";
            chkBRRESAnims.CheckedChanged += new EventHandler(UpdateAnimList_Event);
            // 
            // chkNonBRRESAnims
            // 
            chkNonBRRESAnims.Checked = true;
            chkNonBRRESAnims.CheckOnClick = true;
            chkNonBRRESAnims.CheckState = CheckState.Checked;
            chkNonBRRESAnims.Name = "chkNonBRRESAnims";
            chkNonBRRESAnims.Size = new System.Drawing.Size(244, 22);
            chkNonBRRESAnims.Text = "Display animations not in BRRES";
            chkNonBRRESAnims.CheckedChanged += new EventHandler(UpdateAnimList_Event);
            // 
            // syncKinectToolStripMenuItem
            // 
            syncKinectToolStripMenuItem.Name = "syncKinectToolStripMenuItem";
            syncKinectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // notYetImplementedToolStripMenuItem
            // 
            notYetImplementedToolStripMenuItem.Name = "notYetImplementedToolStripMenuItem";
            notYetImplementedToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // startTrackingToolStripMenuItem
            // 
            startTrackingToolStripMenuItem.Name = "startTrackingToolStripMenuItem";
            startTrackingToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // models
            // 
            models.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                             | AnchorStyles.Left
                                             | AnchorStyles.Right;
            models.DropDownStyle = ComboBoxStyle.DropDownList;
            models.FormattingEnabled = true;
            models.Items.AddRange(new object[]
            {
                "All"
            });
            models.Location = new System.Drawing.Point(292, 1);
            models.Name = "models";
            models.Size = new System.Drawing.Size(110, 21);
            models.TabIndex = 21;
            models.SelectedIndexChanged += new EventHandler(models_SelectedIndexChanged);
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(splitter1);
            controlPanel.Controls.Add(toolStrip1);
            controlPanel.Controls.Add(panel2);
            controlPanel.Dock = DockStyle.Top;
            controlPanel.Location = new System.Drawing.Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new System.Drawing.Size(805, 26);
            controlPanel.TabIndex = 22;
            controlPanel.Visible = false;
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(402, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(3, 26);
            splitter1.TabIndex = 31;
            splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[]
            {
                chkBones,
                chkPolygons,
                chkVertices,
                chkCollisions,
                dropdownOverlays,
                toolStripSeparator1,
                chkFloor,
                button1,
                chkZoomExtents,
                btnSaveCam,
                toolStripSeparator2,
                cboToolSelect
            });
            toolStrip1.Location = new System.Drawing.Point(402, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(6, 0, 0, 0);
            toolStrip1.Size = new System.Drawing.Size(403, 26);
            toolStrip1.TabIndex = 30;
            toolStrip1.Text = "toolStrip1";
            // 
            // chkBones
            // 
            chkBones.Checked = true;
            chkBones.CheckState = CheckState.Checked;
            chkBones.DisplayStyle = ToolStripItemDisplayStyle.Text;
            chkBones.ImageTransparentColor = Drawing.Color.Magenta;
            chkBones.Name = "chkBones";
            chkBones.Size = new System.Drawing.Size(43, 23);
            chkBones.Text = "Bones";
            chkBones.Click += new EventHandler(toggleRenderBones_Event);
            // 
            // chkPolygons
            // 
            chkPolygons.Checked = true;
            chkPolygons.CheckState = CheckState.Checked;
            chkPolygons.DisplayStyle = ToolStripItemDisplayStyle.Text;
            chkPolygons.ImageTransparentColor = Drawing.Color.Magenta;
            chkPolygons.Name = "chkPolygons";
            chkPolygons.Size = new System.Drawing.Size(60, 23);
            chkPolygons.Text = "Polygons";
            chkPolygons.Click += new EventHandler(toggleRenderPolygons_Event);
            // 
            // chkVertices
            // 
            chkVertices.DisplayStyle = ToolStripItemDisplayStyle.Text;
            chkVertices.ImageTransparentColor = Drawing.Color.Magenta;
            chkVertices.Name = "chkVertices";
            chkVertices.Size = new System.Drawing.Size(51, 23);
            chkVertices.Text = "Vertices";
            chkVertices.Click += new EventHandler(toggleRenderVertices_Event);
            // 
            // chkCollisions
            // 
            chkCollisions.Checked = true;
            chkCollisions.CheckState = CheckState.Checked;
            chkCollisions.DisplayStyle = ToolStripItemDisplayStyle.Text;
            chkCollisions.ImageTransparentColor = Drawing.Color.Magenta;
            chkCollisions.Name = "chkCollisions";
            chkCollisions.Size = new System.Drawing.Size(62, 23);
            chkCollisions.Text = "Collisions";
            chkCollisions.Visible = false;
            chkCollisions.Click += new EventHandler(toggleRenderCollisions_Event);
            // 
            // dropdownOverlays
            // 
            dropdownOverlays.DisplayStyle = ToolStripItemDisplayStyle.Text;
            dropdownOverlays.DropDownItems.AddRange(new ToolStripItem[]
            {
                chkAllOverlays,
                chkBoundaries,
                chkSpawns,
                chkItems
            });
            dropdownOverlays.ImageTransparentColor = Drawing.Color.Magenta;
            dropdownOverlays.Name = "dropdownOverlays";
            dropdownOverlays.Size = new System.Drawing.Size(65, 23);
            dropdownOverlays.Text = "Overlays";
            // 
            // chkAllOverlays
            // 
            chkAllOverlays.Checked = true;
            chkAllOverlays.CheckOnClick = true;
            chkAllOverlays.CheckState = CheckState.Checked;
            chkAllOverlays.Name = "chkAllOverlays";
            chkAllOverlays.Size = new System.Drawing.Size(171, 22);
            chkAllOverlays.Text = "All";
            chkAllOverlays.CheckedChanged += new EventHandler(chkAllOverlays_CheckedChanged);
            // 
            // chkBoundaries
            // 
            chkBoundaries.Checked = true;
            chkBoundaries.CheckOnClick = true;
            chkBoundaries.CheckState = CheckState.Checked;
            chkBoundaries.Name = "chkBoundaries";
            chkBoundaries.Size = new System.Drawing.Size(171, 22);
            chkBoundaries.Text = "Boundaries";
            chkBoundaries.Click += new EventHandler(chkBoundaries_Click);
            // 
            // chkSpawns
            // 
            chkSpawns.Checked = true;
            chkSpawns.CheckOnClick = true;
            chkSpawns.CheckState = CheckState.Checked;
            chkSpawns.Name = "chkSpawns";
            chkSpawns.Size = new System.Drawing.Size(171, 22);
            chkSpawns.Text = "Spawn/Respawns";
            chkSpawns.Click += new EventHandler(chkBoundaries_Click);
            // 
            // chkItems
            // 
            chkItems.Checked = true;
            chkItems.CheckOnClick = true;
            chkItems.CheckState = CheckState.Checked;
            chkItems.Name = "chkItems";
            chkItems.Size = new System.Drawing.Size(171, 22);
            chkItems.Text = "Item Spawn Zones";
            chkItems.Click += new EventHandler(chkBoundaries_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // chkFloor
            // 
            chkFloor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            chkFloor.ImageTransparentColor = Drawing.Color.Magenta;
            chkFloor.Name = "chkFloor";
            chkFloor.Size = new System.Drawing.Size(38, 23);
            chkFloor.Text = "Floor";
            chkFloor.Click += new EventHandler(toggleRenderFloor_Event);
            // 
            // button1
            // 
            button1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            button1.ImageTransparentColor = Drawing.Color.Magenta;
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(83, 23);
            button1.Text = "Reset Camera";
            button1.Click += new EventHandler(resetCameraToolStripMenuItem_Click_1);
            // 
            // chkZoomExtents
            // 
            chkZoomExtents.DisplayStyle = ToolStripItemDisplayStyle.Text;
            chkZoomExtents.ImageTransparentColor = Drawing.Color.Magenta;
            chkZoomExtents.Name = "chkZoomExtents";
            chkZoomExtents.Size = new System.Drawing.Size(83, 19);
            chkZoomExtents.Text = "Zoom Extents";
            chkZoomExtents.Click += new EventHandler(chkZoomExtents_Click);
            // 
            // btnSaveCam
            // 
            btnSaveCam.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSaveCam.ImageTransparentColor = Drawing.Color.Magenta;
            btnSaveCam.Name = "btnSaveCam";
            btnSaveCam.Size = new System.Drawing.Size(79, 19);
            btnSaveCam.Text = "Save Camera";
            btnSaveCam.Click += new EventHandler(btnSaveCam_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // cboToolSelect
            // 
            cboToolSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cboToolSelect.FlatStyle = FlatStyle.Standard;
            cboToolSelect.Items.AddRange(new object[]
            {
                "Translation",
                "Rotation",
                "Scale",
                "None"
            });
            cboToolSelect.Name = "cboToolSelect";
            cboToolSelect.Size = new System.Drawing.Size(121, 23);
            cboToolSelect.SelectedIndexChanged += new EventHandler(cboToolSelect_SelectedIndexChanged);
            // 
            // panel2
            // 
            panel2.Controls.Add(models);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(402, 26);
            panel2.TabIndex = 29;
            // 
            // spltRight
            // 
            spltRight.Dock = DockStyle.Right;
            spltRight.Location = new System.Drawing.Point(601, 26);
            spltRight.Name = "spltRight";
            spltRight.Size = new System.Drawing.Size(4, 389);
            spltRight.TabIndex = 23;
            spltRight.TabStop = false;
            spltRight.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(modelPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(189, 41);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(397, 359);
            panel1.TabIndex = 25;
            // 
            // modelPanel
            // 
            modelPanel.BackColor = Drawing.Color.Lavender;
            modelPanelViewport1.BackgroundColor = Drawing.Color.FromArgb(0, 240, 240, 240);
            modelPanelViewport1.BackgroundImage = null;
            modelPanelViewport1.BackgroundImageType = BGImageType.Stretch;
            glCamera1.Aspect = 1.10585F;
            glCamera1.FarDepth = 200000F;
            glCamera1.Height = 359F;
            glCamera1.NearDepth = 1F;
            glCamera1.Orthographic = false;
            glCamera1.VerticalFieldOfView = 45F;
            glCamera1.Width = 397F;
            modelPanelViewport1.Camera = glCamera1;
            modelPanelViewport1.Enabled = true;
            modelPanelViewport1.Region = new Drawing.Rectangle(0, 0, 397, 359);
            modelPanelViewport1.RotationScale = 0.4F;
            modelPanelViewport1.TranslationScale = 0.05F;
            modelPanelViewport1.ViewType = ViewportProjection.Perspective;
            modelPanelViewport1.ZoomScale = 2.5F;
            modelPanel.CurrentViewport = modelPanelViewport1;
            modelPanel.Dock = DockStyle.Fill;
            modelPanel.Location = new System.Drawing.Point(0, 0);
            modelPanel.Name = "modelPanel";
            modelPanel.Size = new System.Drawing.Size(397, 359);
            modelPanel.TabIndex = 0;
            modelPanel.RenderFloorChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderFloorChanged);
            modelPanel.FirstPersonCameraChanged += new ModelPanel.RenderStateEvent(modelPanel_FirstPersonCameraChanged);
            modelPanel.RenderBonesChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderBonesChanged);
            modelPanel.RenderMetalChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderMetalsChanged);
            modelPanel.RenderModelBoxChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderModelBoxChanged);
            modelPanel.RenderObjectBoxChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderObjectBoxChanged);
            modelPanel.RenderVisBoneBoxChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderVisBoneBoxChanged);
            modelPanel.RenderOffscreenChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderOffscreenChanged);
            modelPanel.RenderVerticesChanged += new ModelPanel.RenderStateEvent(ModelPanel_RenderVerticesChanged);
            modelPanel.RenderNormalsChanged += new ModelPanel.RenderStateEvent(modelPanel_RenderNormalsChanged);
            modelPanel.RenderPolygonsChanged += new ModelPanel.RenderStateEvent(ModelPanel_RenderPolygonsChanged);
            modelPanel.RenderWireframeChanged += new ModelPanel.RenderStateEvent(ModelPanel_RenderWireframeChanged);
            modelPanel.UseBindStateBoxesChanged += new ModelPanel.RenderStateEvent(ModelPanel_UseBindStateBoxesChanged);
            modelPanel.ApplyBillboardBonesChanged +=
                new ModelPanel.RenderStateEvent(ModelPanel_ApplyBillboardBonesChanged);
            modelPanel.RenderShadersChanged += new ModelPanel.RenderStateEvent(ModelPanel_RenderShadersChanged);
            modelPanel.ScaleBonesChanged += new ModelPanel.RenderStateEvent(ModelPanel_ScaleBonesChanged);
            modelPanel.OnCurrentViewportChanged += new ViewportAction(modelPanel_OnCurrentViewportChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 157);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 13);
            label1.TabIndex = 0;
            label1.Text = "Open";
            // 
            // animEditors
            // 
            animEditors.AutoScroll = true;
            animEditors.Controls.Add(pnlPlayback);
            animEditors.Controls.Add(animCtrlPnl);
            animEditors.Dock = DockStyle.Bottom;
            animEditors.Location = new System.Drawing.Point(0, 415);
            animEditors.Name = "animEditors";
            animEditors.Size = new System.Drawing.Size(805, 60);
            animEditors.TabIndex = 29;
            animEditors.Visible = false;
            // 
            // pnlPlayback
            // 
            pnlPlayback.Dock = DockStyle.Fill;
            pnlPlayback.Enabled = false;
            pnlPlayback.Location = new System.Drawing.Point(264, 0);
            pnlPlayback.MinimumSize = new System.Drawing.Size(290, 54);
            pnlPlayback.Name = "pnlPlayback";
            pnlPlayback.Size = new System.Drawing.Size(541, 60);
            pnlPlayback.TabIndex = 15;
            // 
            // animCtrlPnl
            // 
            animCtrlPnl.AutoScroll = true;
            animCtrlPnl.Controls.Add(vis0Editor);
            animCtrlPnl.Controls.Add(pat0Editor);
            animCtrlPnl.Controls.Add(shp0Editor);
            animCtrlPnl.Controls.Add(srt0Editor);
            animCtrlPnl.Controls.Add(chr0Editor);
            animCtrlPnl.Controls.Add(scn0Editor);
            animCtrlPnl.Controls.Add(clr0Editor);
            animCtrlPnl.Controls.Add(weightEditor);
            animCtrlPnl.Controls.Add(vertexEditor);
            animCtrlPnl.Dock = DockStyle.Left;
            animCtrlPnl.Location = new System.Drawing.Point(0, 0);
            animCtrlPnl.Name = "animCtrlPnl";
            animCtrlPnl.Size = new System.Drawing.Size(264, 60);
            animCtrlPnl.TabIndex = 29;
            // 
            // vis0Editor
            // 
            vis0Editor.Dock = DockStyle.Fill;
            vis0Editor.Location = new System.Drawing.Point(0, 0);
            vis0Editor.MinimumSize = new System.Drawing.Size(210, 55);
            vis0Editor.Name = "vis0Editor";
            vis0Editor.Padding = new Padding(4);
            vis0Editor.Size = new System.Drawing.Size(264, 60);
            vis0Editor.TabIndex = 26;
            vis0Editor.Visible = false;
            // 
            // pat0Editor
            // 
            pat0Editor.Dock = DockStyle.Fill;
            pat0Editor.Location = new System.Drawing.Point(0, 0);
            pat0Editor.MinimumSize = new System.Drawing.Size(402, 77);
            pat0Editor.Name = "pat0Editor";
            pat0Editor.Size = new System.Drawing.Size(402, 77);
            pat0Editor.TabIndex = 27;
            pat0Editor.Visible = false;
            // 
            // shp0Editor
            // 
            shp0Editor.Dock = DockStyle.Fill;
            shp0Editor.Location = new System.Drawing.Point(0, 0);
            shp0Editor.MinimumSize = new System.Drawing.Size(533, 106);
            shp0Editor.Name = "shp0Editor";
            shp0Editor.Size = new System.Drawing.Size(533, 106);
            shp0Editor.TabIndex = 28;
            shp0Editor.Visible = false;
            // 
            // srt0Editor
            // 
            srt0Editor.Dock = DockStyle.Fill;
            srt0Editor.Location = new System.Drawing.Point(0, 0);
            srt0Editor.MinimumSize = new System.Drawing.Size(483, 78);
            srt0Editor.Name = "srt0Editor";
            srt0Editor.Size = new System.Drawing.Size(483, 78);
            srt0Editor.TabIndex = 20;
            srt0Editor.Visible = false;
            // 
            // chr0Editor
            // 
            chr0Editor.Dock = DockStyle.Fill;
            chr0Editor.Location = new System.Drawing.Point(0, 0);
            chr0Editor.MinimumSize = new System.Drawing.Size(582, 78);
            chr0Editor.Name = "chr0Editor";
            chr0Editor.Size = new System.Drawing.Size(582, 78);
            chr0Editor.TabIndex = 19;
            chr0Editor.Visible = false;
            // 
            // scn0Editor
            // 
            scn0Editor.Dock = DockStyle.Fill;
            scn0Editor.Location = new System.Drawing.Point(0, 0);
            scn0Editor.Name = "scn0Editor";
            scn0Editor.Size = new System.Drawing.Size(264, 60);
            scn0Editor.TabIndex = 30;
            scn0Editor.Visible = false;
            // 
            // clr0Editor
            // 
            clr0Editor.Dock = DockStyle.Fill;
            clr0Editor.Location = new System.Drawing.Point(0, 0);
            clr0Editor.MinimumSize = new System.Drawing.Size(256, 40);
            clr0Editor.Name = "clr0Editor";
            clr0Editor.Size = new System.Drawing.Size(264, 60);
            clr0Editor.TabIndex = 30;
            clr0Editor.Visible = false;
            // 
            // weightEditor
            // 
            weightEditor.Dock = DockStyle.Fill;
            weightEditor.Location = new System.Drawing.Point(0, 0);
            weightEditor.MinimumSize = new System.Drawing.Size(260, 103);
            weightEditor.Name = "weightEditor";
            weightEditor.Size = new System.Drawing.Size(264, 103);
            weightEditor.TabIndex = 31;
            weightEditor.Visible = false;
            weightEditor.WeightIncrement = 0.1F;
            // 
            // vertexEditor
            // 
            vertexEditor.Dock = DockStyle.Fill;
            vertexEditor.Enabled = false;
            vertexEditor.Location = new System.Drawing.Point(0, 0);
            vertexEditor.MinimumSize = new System.Drawing.Size(230, 85);
            vertexEditor.Name = "vertexEditor";
            vertexEditor.Size = new System.Drawing.Size(264, 85);
            vertexEditor.TabIndex = 32;
            vertexEditor.Visible = false;
            // 
            // rightPanel
            // 
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new System.Drawing.Point(605, 26);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new System.Drawing.Size(200, 389);
            rightPanel.TabIndex = 32;
            rightPanel.Visible = false;
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new System.Drawing.Point(0, 26);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new System.Drawing.Size(170, 389);
            leftPanel.TabIndex = 4;
            leftPanel.Visible = false;
            // 
            // ModelEditControl
            // 
            AllowDrop = true;
            Controls.Add(panel1);
            Controls.Add(btnTopToggle);
            Controls.Add(btnBottomToggle);
            Controls.Add(btnRightToggle);
            Controls.Add(spltRight);
            Controls.Add(rightPanel);
            Controls.Add(btnLeftToggle);
            Controls.Add(spltLeft);
            Controls.Add(leftPanel);
            Controls.Add(controlPanel);
            Controls.Add(animEditors);
            Name = "ModelEditControl";
            Size = new System.Drawing.Size(805, 475);
            SizeChanged += new EventHandler(ModelEditControl_SizeChanged);
            DragDrop += new DragEventHandler(OnDragDrop);
            DragEnter += new DragEventHandler(OnDragEnter);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            animEditors.ResumeLayout(false);
            animCtrlPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        #region Initialization

        public ModelEditControl()
        {
            if (!Instances.Contains(this))
            {
                Instances.Add(this);
            }

            InitializeComponent();

            leftPanel._mainWindow = this;
            rightPanel.pnlKeyframes._mainWindow =
                rightPanel.pnlBones._mainWindow =
                    rightPanel.pnlOpenedFiles._mainWindow =
                        weightEditor._mainWindow =
                            vertexEditor._mainWindow =
                                srt0Editor._mainWindow =
                                    shp0Editor._mainWindow =
                                        pat0Editor._mainWindow =
                                            vis0Editor._mainWindow =
                                                scn0Editor._mainWindow =
                                                    clr0Editor._mainWindow =
                                                        chr0Editor._mainWindow =
                                                            pnlPlayback._mainWindow =
                                                                this;

            PreConstruct();

            ModelPanel.DrawCallSort = rightPanel.pnlOpenedFiles.Sort;

            leftPanel.fileType.DataSource = _editableAnimTypes;
            TargetAnimType = NW4RAnimType.CHR;

            animEditors.HorizontalScroll.Enabled =
                !(animEditors.Width - animCtrlPnl.Width >= pnlPlayback.MinimumSize.Width);

            string applicationFolder = "C:";
            try
            {
                applicationFolder = IO.Path.GetDirectoryName(Reflection.Assembly.GetEntryAssembly().Location);
            }
            catch
            {
            }

            ScreenCapBgLocText.Text = applicationFolder + "\\ScreenCaptures";
            MDL0TextureNode.TextureOverrideDirectory =
                LiveTextureFolderPath.Text =
                    applicationFolder;

            _openFileDelegate = new DelegateOpenFile(OpenFile);

            models.DataSource = ModelPanel._renderList;

            PostConstruct();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            panel1.Controls.Add(_interpolationEditor);
            _interpolationEditor.SendToBack();
            _interpolationEditor.Dock = DockStyle.Fill;
            _interpolationEditor.Visible = false;

            cboToolSelect.SelectedIndex = 1;
            chkZoomExtents.Enabled = false;

            _currentProjBox = perspectiveToolStripMenuItem;

            shadersToolStripMenuItem.Enabled = TKContext._shadersSupported;

            rightPanel.pnlOpenedFiles.listBox1.DataSource = _openedFiles;
        }

        #endregion

        public static List<ModelEditControl> Instances = new List<ModelEditControl>();

        private void removeCurrentViewportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelPanel.RemoveViewport(ModelPanel.CurrentViewport);
        }

        public void btnLoadAnimations_Click(object sender, EventArgs e)
        {
            rightPanel.pnlOpenedFiles.LoadExternal(false, true, false);
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            pnlAnimSave(false);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            pnlAnimSave(true);
        }

        private void pnlAnimSave(bool As)
        {
            ResourceNode o = null;
            if (TargetModel != null)
            {
                o = ((ResourceNode) TargetModel).RootNode;
            }
            else
            {
                o = rightPanel.pnlOpenedFiles.SelectedFile;
            }

            rightPanel.pnlOpenedFiles.SaveExternal(o, As);
        }

        public void AppendTarget(CollisionNode collision)
        {
            if (!_collisions.Contains(collision))
            {
                _collisions.Add(collision);
            }

            foreach (CollisionObject o in collision._objects)
            {
                o._render = true;
            }

            chkCollisions.Visible = _collisions.Count > 0;
        }

        public override void LoadModels(ResourceNode node)
        {
            base.LoadModels(node);

            models.SelectedItem = TargetModel;
        }

        public override void LoadAnimations(ResourceNode node)
        {
            leftPanel.LoadAnimations(node);
        }

        private void RemoveAnimGroup(string nameCompare)
        {
            for (int i = 0; i < leftPanel.listAnims.Groups.Count; i++)
            {
                ListViewGroup x = leftPanel.listAnims.Groups[i];
                if (x.ToString().Contains(nameCompare))
                {
                    for (int r = 0; r < x.Items.Count; r++)
                    {
                        leftPanel.listAnims.Items.Remove(x.Items[r--]);
                    }

                    leftPanel.listAnims.Groups.RemoveAt(i--);
                }
            }
        }

        public override void UnloadAnimations(ResourceNode r)
        {
            //leftPanel.UpdateAnimations();
            RemoveAnimGroup(r.RootNode.Name);
        }

        public override void LoadEtc(ResourceNode node)
        {
        }

        public override void OpenInMainForm(ResourceNode node)
        {
            Program.RootNode = node;
        }

        public override bool ShouldCloseFile(ResourceNode node)
        {
            return Program.RootNode != node;
        }

        private void SLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[2] = CoordinateType.Local;
            UpdateCoordinateCheckboxes();
        }

        private void SWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[2] = CoordinateType.World;
            UpdateCoordinateCheckboxes();
        }

        private void SCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[2] = CoordinateType.Screen;
            UpdateCoordinateCheckboxes();
        }

        private void RLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[1] = CoordinateType.Local;
            UpdateCoordinateCheckboxes();
        }

        private void RWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[1] = CoordinateType.World;
            UpdateCoordinateCheckboxes();
        }

        private void RCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[1] = CoordinateType.Screen;
            UpdateCoordinateCheckboxes();
        }

        private void TLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[0] = CoordinateType.Local;
            UpdateCoordinateCheckboxes();
        }

        private void TWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[0] = CoordinateType.World;
            UpdateCoordinateCheckboxes();
        }

        private void TCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _coordinateTypes[0] = CoordinateType.Screen;
            UpdateCoordinateCheckboxes();
        }

        private void UpdateCoordinateCheckboxes()
        {
            TLocalToolStripMenuItem.Checked = _coordinateTypes[0] == CoordinateType.Local;
            TWorldToolStripMenuItem.Checked = _coordinateTypes[0] == CoordinateType.World;
            TCameraToolStripMenuItem.Checked = _coordinateTypes[0] == CoordinateType.Screen;

            RLocalToolStripMenuItem.Checked = _coordinateTypes[1] == CoordinateType.Local;
            RWorldToolStripMenuItem.Checked = _coordinateTypes[1] == CoordinateType.World;
            RCameraToolStripMenuItem.Checked = _coordinateTypes[1] == CoordinateType.Screen;

            SLocalToolStripMenuItem.Checked = _coordinateTypes[2] == CoordinateType.Local;
            SWorldToolStripMenuItem.Checked = _coordinateTypes[2] == CoordinateType.World;
            SCameraToolStripMenuItem.Checked = _coordinateTypes[2] == CoordinateType.Screen;

            ModelPanel.Invalidate();
        }

        private void afterRotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _translateAfterRotation = afterRotationToolStripMenuItem.Checked = !afterRotationToolStripMenuItem.Checked;
            ModelPanel.Invalidate();
        }

        private void sCN0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelPanel.CurrentViewport.RenderSCN0Controls =
                sCN0ToolStripMenuItem.Checked = !sCN0ToolStripMenuItem.Checked;
        }

        protected override void modelPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !(_scaling || _translating || _rotating))
            {
                weightEditor.TargetVertices = _selectedVertices;
                vertexEditor.TargetVertices = _selectedVertices;
            }

            base.modelPanel1_MouseUp(sender, e);
        }

        private void btnWeightEditor_Click(object sender, EventArgs e)
        {
            ToggleWeightEditor();
        }

        private void btnVertexEditor_Click(object sender, EventArgs e)
        {
            ToggleVertexEditor();
        }
    }
}