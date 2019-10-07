﻿using System.Windows.Forms;
using MT_Forms.CommonMethods;
using MT_Forms.PageObjects;
using NLog;

namespace MT_Forms.Scripts
{
    internal class VisokaiaTemnitsa
    {
        private Logger _log = LogManager.GetCurrentClassLogger();
        private readonly DungeonButtons _dungeonButtons;
        private readonly QuestsButtons _questsButtons;

        public VisokaiaTemnitsa()
        {
            _dungeonButtons = new DungeonButtons();
            _questsButtons = new QuestsButtons();
        }

        public void VisokaiaTemnitsaScript()
        {
            new GoToUrl().NavigateToUrl("https://m.vten.ru/quest/qHeroicHighDungeonDaily");
            _questsButtons.findGangButton.Click();
            _dungeonButtons.enterInDungeon.Click();
            _dungeonButtons.startBattle.Click();

            if (new Form1().GoForTheCasketCheckBox.CheckState == CheckState.Unchecked)
            {
                GoInDungeonForTheCasketAndItems();
            }
            else if (new Form1().GoForTheCasketCheckBox.CheckState == CheckState.Checked)
            {
                GoInDungeonOnlyForTheCasket();
            }
        }

        private void GoInDungeonForTheCasketAndItems()
        {
            _log.Info("User go in 'Vysokaia Temnitsa' for the casket and items");
            while (true)
            {
                if (!_dungeonButtons.CheckWaveIsComplete() && !_dungeonButtons.CheckDungeonIsComplete() && !_dungeonButtons.CheckGiveRewardLinkIsVisible())
                {
                    _dungeonButtons.ClickOnFirstAttackButton();
                }
                else if (_dungeonButtons.CheckWaveIsComplete())
                {
                    _dungeonButtons.continueBattle.Click();
                }
                else if (_dungeonButtons.CheckDungeonIsComplete())
                {
                    break;
                }
            }
            _dungeonButtons.giveRewardLink.Click();
            _questsButtons.continueAdventures.Click();
        }

        private void GoInDungeonOnlyForTheCasket()
        {
            _log.Info("User go in 'Vysokaia Temnitsa' only for the casket");
            while (true)
            {
                if (!_dungeonButtons.CheckWaveIsComplete() && !_dungeonButtons.CheckDungeonIsComplete() && !_dungeonButtons.CheckGiveRewardLinkIsVisible())
                {
                    _dungeonButtons.ClickOnFirstAttackButton();
                }
                else if (_dungeonButtons.CheckWaveIsComplete())
                {
                    _dungeonButtons.continueBattle.Click();
                }
                else if (_dungeonButtons.CheckGiveRewardLinkIsVisible())
                {
                    _dungeonButtons.giveRewardLink.Click();
                    _questsButtons.continueAdventures.Click();
                    break;
                }
            }
        }
    }
}
