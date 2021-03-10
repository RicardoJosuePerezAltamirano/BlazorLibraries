using BlazorLibraries.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLibraries.Client.Pages
{
    public partial class PanelComponents
    {
        [Parameter]
        public List<Model> textModelComponents { get; set; }
        [Inject]
        public DemoViewModel DemoViewModel { get; set; }
        private async Task catchDrop()
        {
            /*
             *  se llama  a preventDefault () para evitar que el navegador maneje los datos por defecto (el valor predeterminado es abrir como enlace al soltar)
    Lo que haremos es actualizar el estado del componente ya que lo que va a pasar es que 
            en el modelo se agregaran un nuevo elemento y cuando este agregado, actualizando se mostrara en la vista
             * */
            textModelComponents.Add(DemoViewModel.ModelSelected);
            
            
        }
    }
}
