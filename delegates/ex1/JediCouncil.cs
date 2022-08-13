using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    public delegate void Notification(string message);
    
    public class JediCouncil
    {
        public event Notification CouncilChanged;
       List<Jedi> members = new List<Jedi>();
        public void Add(Jedi newJedi)
        {
            members.Add(newJedi);
            if (CouncilChanged != null)
                CouncilChanged("A new member was added to the council.");
        }
        public void Remove()
        {
            // Removes the 0th item from the list
            members.RemoveAt(0);
            if (CouncilChanged != null)
            {
                if (members.Count > 0)
                    CouncilChanged("I sense a disturbance in the Force.");
                else
                    CouncilChanged("The council is over!");
            }
        }

        public List<Jedi>  GetStrongestMebers()
        {
            return members.FindAll(
            delegate (Jedi b)
            {
                return b.midiChlorianCount > 17000;
            }
            );
        }





    }
}
