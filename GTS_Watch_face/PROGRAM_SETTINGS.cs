﻿namespace GTS_Watch_face
{
    class PROGRAM_SETTINGS
    {
        public bool Settings_Unpack_Dialog = true;
        public bool Settings_Unpack_Save = false;
        public bool Settings_Unpack_Replace = false;

        public bool Settings_Pack_Dialog = false;
        public bool Settings_Pack_GoToFile = true;
        public bool Settings_Pack_Copy = false;
        public bool Settings_Pack_DoNotning = false;

        public bool Settings_AfterUnpack_Dialog = false;
        public bool Settings_AfterUnpack_Download = true;
        public bool Settings_AfterUnpack_DoNothing = false;

        public bool Settings_Open_Dialog = false;
        public bool Settings_Open_Download = true;
        public bool Settings_Open_DoNotning = false;

        public bool Model_47 = true;
        public bool Model_42 = false;

        public bool ShowBorder = false;
        public float Scale = 1f;
        public float Gif_Speed = 1f;

        public string pack_unpack_dir { get; set; }
        public string unpack_command_47 = "--gts --file";
        public string pack_command_47 = "--gts --file";
        public string unpack_command_42 = "--gts --file";
        public string pack_command_42 = "--gts --file";

        public string language { get; set; }
    }
}
