﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murder.Core;
/// <summary>
/// A struct representing information about a single animation frame, such as its index in the list and a flag indicating whether the animation is complete
/// </summary>
public ref struct FrameInfo
{
    internal static FrameInfo Fail => new() { Failed = true };

    /// <summary>
    /// The index of the current frame
    /// </summary>
    public readonly int Frame;
    
    /// <summary>
    /// Whether the animation is complete
    /// </summary>
    public readonly bool Complete;

    public readonly bool Failed { get; init; }
    
    /// <summary>
    /// A string ID representing the event associated with the current frame (if any). Usually set in Aseprite
    /// </summary>
    public readonly ReadOnlySpan<char> Event;

    public FrameInfo(int frame, bool animationComplete, ReadOnlySpan<char> @event)
    {
        Frame = frame;
        Complete = animationComplete;
        Event = @event;
    }

    public FrameInfo(int frame, bool animationComplete) : this()
    {
        Frame = frame;
        Complete = animationComplete;
    }
}