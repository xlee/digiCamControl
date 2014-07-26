﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CameraControl.Core.Interfaces;
using CameraControl.Core.Translation;

namespace CameraControl.Plugins.ToolPlugins
{
    public class GenMoviePlugin :IToolPlugin
    {
        public bool Execute()
        {
            GenMovieWindow window = new GenMovieWindow();
            window.DataContext = new GenMovieViewModel(window);
            window.ShowDialog();
            return true;
        }

        public string Title { get; set; }

        public GenMoviePlugin()
        {
            Title = TranslationStrings.LabelCreateMovie;
        }
    }
}
