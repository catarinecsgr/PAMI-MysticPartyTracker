using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class CharacterViewModel : ObservableObject
    {
        public CharacterViewModel()
        {
            CriarPersonagemCommand = new Command(CriarPersonagem);
        }

        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private string _classe;

        [ObservableProperty]
        private string _raca;

        [ObservableProperty]
        private int _level;

        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set { _characters = value; }
        }

        public ICommand CriarPersonagemCommand { get; }

        public void CriarPersonagem()
        {
            _characters.Add(new Character(Nome, Classe, Raca, Level));
        }
    }
}