using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePollito.Models
{
    public partial class ConexionCorralModel : ObservableObject
    {
        [ObservableProperty]
        private string? ip;
        [ObservableProperty]
        private string? nombre;
        [ObservableProperty]
        private string? pollito;
    }
}
