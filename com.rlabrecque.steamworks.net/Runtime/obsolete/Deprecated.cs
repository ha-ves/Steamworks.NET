// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2024 Haves Irfan
// Please see the included LICENSE.txt for additional information.

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

namespace Steamworks
{
    public static class Deprecated
    {
        
    }
}

#endif // !DISABLESTEAMWORKS
