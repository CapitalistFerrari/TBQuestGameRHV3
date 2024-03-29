﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGameRH.Models;
using TBQuestGameRH.DataLayer;
using TBQuestGameRH.BusinessLayer;

namespace TBQuestGameRH.PresentationLayer
{
    public partial class GameSessionViewModel : ObservableObject
    {
        #region FIELDS 

        public DateTime _gameStartTime;
        private Player _player;
        private List<string> _messages;
        private Location[,] _gameMap;
        private int _maxRows, _maxColumns;
        private GameMapCoordinates _currentLocationCoordinates;
        private Location _currentLocation;
        private Location _alphaLocation, _betaLocation, _gammaLocation, _deltaLocation;
        private bool _hasAlphaLocation, _hasBetaLocation, _hasGammaLocation, _hasDeltaLocation;
        public DateTime _datetime;

        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player;  }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessagesForViewer(); }
        }

        public Location[,] GameMap
        {
            get { return _gameMap; }
            set { _gameMap = value; }
        }
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasAlphaLocation");
                OnPropertyChanged("HasBetaLocation");
                OnPropertyChanged("HasGammaLocation");
                OnPropertyChanged("HasDeltaLocation");
            }
        }

        public Location AlphaLocation
        {
            get { return _alphaLocation; }
            set
            {
                _alphaLocation = value;
                OnPropertyChanged("AlphaLocation");
            }
        }
        public Location BetaLocation
        {
            get { return _betaLocation; }
            set
            {
                _betaLocation = value;
                OnPropertyChanged("BetaLocation");
            }
        }
        public Location GammaLocation
        {
            get { return _gammaLocation; }
            set
            {
                _gammaLocation = value;
                OnPropertyChanged("GammaLocation");
            }
        }
        public Location DeltaLocation
        {
            get { return _deltaLocation; }
            set
            {
                _deltaLocation = value;
                OnPropertyChanged("DeltaLocation");
            }
        }
        public bool HasAlphaLocation { get { return _hasAlphaLocation; } }
        public bool HasBetaLocation { get { return _hasBetaLocation; } }
        public bool HasGammaLocation { get { return _hasGammaLocation; } }
        public bool HasDeltaLocation { get { return _hasDeltaLocation; } }


        #endregion

        #region CONSTRUCTORS

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player,
            List<string> initialMessages,
            Location[,] gameMap,
            GameMapCoordinates currentLocationCoordinates)
        {
            _player = player;
            _messages = initialMessages;

            _gameMap = gameMap;
            _maxRows = _gameMap.GetLength(0);
            _maxColumns = _gameMap.GetLength(1);

            _currentLocationCoordinates = currentLocationCoordinates;
            _currentLocation = _gameMap[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column];

        }

        #endregion

        #region METHODS
        private string FormatMessagesForViewer()
        {
            List<string> lifoMessages = new List<string>();

            for (int index = 0; index < _messages.Count; index++)
            {
                lifoMessages.Add(_messages[index]);
            }

            lifoMessages.Reverse();

            return string.Join("\n\n", lifoMessages);
        }
        private void InitializeView()
        {
            InitializeGameMap();
            UpdateAvailableTravelPoints();
        }

        /// <summary>
        /// fill all empty game map locations with an empty location object
        /// </summary>
        private void InitializeGameMap()
        {
            for (int row = 0; row < _maxRows; row++)
            {
                for (int column = 0; column < _maxColumns; column++)
                {
                    if (_gameMap[row, column] == null)
                    {
                        _gameMap[row, column] = EmptyLocation();
                    }
                }
            }
        }

        public Location EmptyLocation()
        {
            return new Location()
            {
                Id = 0,
                Name = "You can't go that way.",
                Description = "All energy flows according to the whims of the great magnet. what a fool I was to defy him.",
                Accessible = true
            };
        }

        /// <summary>
        /// calculate the available travel points from current location
        /// game slipstreams are a mapping against the 2D array where 
        /// Alpha = North
        /// Beta = East
        /// Gamma = South
        /// Delta = West
        /// </summary>
        private void UpdateAvailableTravelPoints()
        {
            //
            // reset travel location information
            //
            _alphaLocation = EmptyLocation();
            _betaLocation = EmptyLocation();
            _gammaLocation = EmptyLocation();
            _deltaLocation = EmptyLocation();
            _hasAlphaLocation = false;
            _hasBetaLocation = false;
            _hasGammaLocation = false;
            _hasDeltaLocation = false;

            //
            // not on north boundary of map array (alpha)
            //
            if (_currentLocationCoordinates.Row > 0)
            {
                if (_gameMap[_currentLocationCoordinates.Row - 1, _currentLocationCoordinates.Column].Id != 0) // location exists
                {
                    AlphaLocation = _gameMap[_currentLocationCoordinates.Row - 1, _currentLocationCoordinates.Column];
                    _hasAlphaLocation = true;
                }
            }

            //
            // not on south boundary of map array (gamma)
            //
            if (_currentLocationCoordinates.Row < _maxRows - 1)
            {
                if (_gameMap[_currentLocationCoordinates.Row + 1, _currentLocationCoordinates.Column].Id != 0) // location exists
                {
                    GammaLocation = _gameMap[_currentLocationCoordinates.Row + 1, _currentLocationCoordinates.Column];
                    _hasGammaLocation = true;
                }

            }

            //
            // not on west boundary of map array (delta)
            //
            if (_currentLocationCoordinates.Column > 0)
            {
                if (_gameMap[_currentLocationCoordinates.Column, _currentLocationCoordinates.Column - 1].Id != 0) // location exists
                {
                    DeltaLocation = _gameMap[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column - 1];
                    _hasDeltaLocation = true;
                }

            }

            //
            // not on east boundary of map array (beta)
            //
            if (_currentLocationCoordinates.Column < _maxColumns - 1)
            {
                if (_gameMap[_currentLocationCoordinates.Column, _currentLocationCoordinates.Column + 1].Id != 0) // location exists
                {
                    BetaLocation = _gameMap[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column + 1];
                    _hasBetaLocation = true;
                }

            }
        }

        public void AlphaTravel()
        {
            _currentLocationCoordinates.Row--;
            CurrentLocation = _gameMap[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column];
            UpdateAvailableTravelPoints();
        }

        public void BetaTravel()
        {
            _currentLocationCoordinates.Column++;
            CurrentLocation = _gameMap[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column];
            UpdateAvailableTravelPoints();
        }

        public void GammaTravel()
        {
            _currentLocationCoordinates.Row++;
            CurrentLocation = _gameMap[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column];
            UpdateAvailableTravelPoints();
        }

        public void DeltaTravel()
        {
            _currentLocationCoordinates.Column--;
            CurrentLocation = _gameMap[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column];
            UpdateAvailableTravelPoints();
        }
        public TimeSpan GameTime()
        {
            return DateTime.Now - _gameStartTime;
        }

        #endregion
    }
}
