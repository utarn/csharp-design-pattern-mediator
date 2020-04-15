using System;
using System.Collections.Generic;

namespace pattern_mediator
{
    public class UIControl
    {
        private List<Action> _eventHandlers = new List<Action>();

        public void AddEventHandler(Action observer)
        {
            _eventHandlers.Add(observer);
        }

        protected void NotifyEventHandlers()
        {
            foreach (var eventHandler in _eventHandlers)
            {
                eventHandler.Invoke();
            }
        }
    }
}