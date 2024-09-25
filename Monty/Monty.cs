using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Monty
{
    public class Monty
    {
        protected int doors;
        protected int openedDoors;
        protected int prizes = 1;
        protected double initialChance;
        protected double doorsLeft;

        protected double probWinningByChanging;
        protected double probWinningByStaying;

        public Monty(int doors, int openedDoors)
        {
            this.doors = doors; this.openedDoors = openedDoors;
            checkIfOk();
            calculateAll();
        }

        public void getAusgabe()
        {
            Console.WriteLine("Probability by changing: {0}%.", Math.Round(this.probWinningByChanging*100,2));
            Console.WriteLine("Probability by staying: {0}%.", Math.Round(this.probWinningByStaying*100,2));
        }

        #region PRIVATE methods
        private void calculateAll() { calcDoorsLeft(); calculateInitialChance(); this.calculateByChanging(); this.calculateByStaying(); }

        private void checkIfOk()
        {
            if (this.doors <= 0 || this.openedDoors <= 0) { throw new ApplicationException("need (more) data + not negative, dude."); }
            if (this.openedDoors >= this.doors - 1) { throw new ApplicationException("no logic, dude."); }
        }

        private void calcDoorsLeft()
        {
            this.doorsLeft = this.doors - this.openedDoors - this.prizes;
        }

        private void calculateInitialChance() { this.initialChance = (double)this.prizes / (double)this.doors; }

        private void calculateByStaying() { this.probWinningByStaying = this.initialChance; }

        private void calculateByChanging()
        {
            double loseChance = ((double)this.doors - (double)this.prizes) / (double)this.doors; //or 1-probWinningByStaying
            double tempWinChance = loseChance;
            this.probWinningByChanging = tempWinChance / (double)this.doorsLeft;
        }
        #endregion
    }
}
