﻿using gym_app.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gym_app.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Catalogos : ContentPage
    {
        public Catalogos()
        {
            InitializeComponent();
            this.BindingContext = new Catalogo();
        }
    }
}