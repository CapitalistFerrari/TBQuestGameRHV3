using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGameRH.Models;
using TBQuestGameRH.DataLayer;
using TBQuestGameRH.PresentationLayer;

namespace TBQuestGameRH.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        bool _newPlayer = false;
        Player _player = new Player();


        public GameBusiness()
        {
            SetupPlayer();
            InstantiateAndShowView();
        }

        
        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _player.CurrentLevel = 0;
                _player.HP = 100;
                _player.CurrentStatus = 0;
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(
                _player,
                GameData.InitialMessages(),
                GameData.GameMap(),
                GameData.InitialGameMapLocation()
                );

            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

        }
    }
}
