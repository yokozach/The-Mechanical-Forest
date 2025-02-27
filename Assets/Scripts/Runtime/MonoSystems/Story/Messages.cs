using Akashic.Core.Messages;
using Akashic.ScriptableObjects.Story;

namespace Akashic.Runtime.MonoSystems.Story
{
    internal sealed class NewStoryEventMessage : IMessage
    {
        public StoryEventData StoryEventData { get; }

        public NewStoryEventMessage(StoryEventData storyEventData)
        {
            StoryEventData = storyEventData;
        }
    }

    internal sealed class StoryPointAvailableMessage : IMessage
    {
    }

    internal sealed class StoryEventEndedMessage : IMessage
    {
    }

    internal sealed class ToggleEventLog : IMessage
    {
        public bool allowLog { get; }

        public ToggleEventLog(bool log)
        {
            allowLog = log;
        }
    }

    internal sealed class StoryEventLogOpened : IMessage
    {
    }

    internal sealed class StoryEventLogClosed : IMessage
    {
    }

    internal sealed class DialogueEntryAvailableMessage: IMessage
    {
        public StoryPoint StoryPoint { get; }

        public DialogueEntryAvailableMessage(StoryPoint storyPoint)
        {
            StoryPoint = storyPoint;
        }
    }
}
