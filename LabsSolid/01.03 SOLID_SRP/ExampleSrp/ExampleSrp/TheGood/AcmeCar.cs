using ExampleSrp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class AcmeCar
    {
        ILoggerException objectException;
        ILoggerState objectState;


        public LockState IsLocked { get; private set; }


        public AcmeCar(ILoggerException objectException, ILoggerState objectState)
        {
            this.objectException = objectException;
            this.objectState = objectState;
       }





        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                objectState.LogChangeState("CarLocked");

            }
            catch (Exception)
            {
                objectException.LockException();
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //
                objectState.LogChangeState("CarUnlocked");

            }
            catch (Exception)
            {
                objectException.UnlockException();

            }

        }
    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }


}

