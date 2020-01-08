using gym_app.Helpers;
using gym_app.modelos;
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
    public partial class MisAsistencias : ContentPage
    {
        private ResFull _res = new ResFull();
        List<Asistencia> asistenciasList = new List<Asistencia>();
        public MisAsistencias()
        {
            InitializeComponent();
            ContextAsisteniciaLista.RefreshCommand = new Command(() =>
              {
                  RefrescarDatos();
                  ContextAsisteniciaLista.IsRefreshing = false;
              });
        }

        protected override void OnAppearing()
        {
            RefrescarDatos();
            base.OnAppearing();
        }

        async public void RefrescarDatos()
        {
            ContextAsisteniciaLista.ItemsSource = null;
            asistenciasList = await _res.Get<List<Asistencia>>("app-mis-asistenicas/" + Settings.IsIdIn);
            ContextAsisteniciaLista.ItemsSource = asistenciasList;
        }



    }
}