﻿using PokerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class PlayerProfile : IPlayer
    {
        private string name;
        private int clientId;
        private float bal;

        //Constructor

        public PlayerProfile(string name, int clientId, float bal)
        {
            this.name = name;
            this.clientId = clientId;
            this.bal = bal;
        }

        // Getters and setters

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public float Bal
        {
            get { return bal; }
            set { bal = value; }
        }

        // Methods

        public string GetData()
        {
            return "Name: " + Name + "\n" + "Client ID: " + clientId + "\n" + "Bal: " + Bal;
        }

        public float AddBal(int _additionAmount)
        {
            bal += _additionAmount;
            return bal;
        }

        public string GetBal()
        {
            return "Current balance: " + Bal;
        }

        public string UpdateName(string _newName)
        {
            name = _newName;
            return "Name has been updated to " + Name;
        }

        public float UpdateBal(float _multiplier, float _betAmountF)
        {
            float winningAmount = _betAmountF * _multiplier;
            Bal -= _betAmountF;
            Bal += winningAmount;
            return Bal;
        }
    }
}
