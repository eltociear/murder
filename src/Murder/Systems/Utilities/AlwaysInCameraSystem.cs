﻿using Bang;
using Bang.Entities;
using Bang.Systems;
using Murder.Components;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murder.Systems.Utilities
{
    [Filter(typeof(SpriteComponent))]
    [Watch(typeof(SpriteComponent))]
    internal class AlwaysInCameraSystem : IReactiveSystem
    {
        public void OnAdded(World world, ImmutableArray<Entity> entities)
        {
            foreach (var e in entities)
            {
                e.SetInCamera();
            }
        }

        public void OnModified(World world, ImmutableArray<Entity> entities)
        {
            
        }

        public void OnRemoved(World world, ImmutableArray<Entity> entities)
        {
            
        }
    }
}
