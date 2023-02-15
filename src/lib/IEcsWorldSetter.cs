/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Piot.Ecs
{
    public interface IEcsWorldSetter
    {
        public void Set<T>(uint entityId, T data) where T : struct;
    }
}