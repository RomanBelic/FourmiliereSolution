using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public delegate void Executable<T> (T parameter);

    public class ChainAction<T, P>
    {
        private ChainAction<T, P> nextAction;
        public ChainAction<T, P> NextAction { get => nextAction; set => nextAction = value; }

        private Predicate<P> predicate;
        public Predicate<P> Predicate { get => predicate; set => predicate = value; }

        private Executable<T> executable;
        public Executable<T> Executable { get => executable; set => executable = value; }

        public ChainAction (Predicate<P> predicate, Executable<T> executable)
        {
            this.predicate = predicate;
            this.executable = executable;
        }

        public ChainAction<T, P> SetNextChaineAction(ChainAction<T,P> action)
        {
            this.nextAction = action;
            return nextAction;
        }

        public virtual void Execute(P pArg, T arg)
        {
            if (predicate(pArg))
                executable(arg);
            if (nextAction != null)
                nextAction.Execute(pArg, arg);
        }
    }
}
