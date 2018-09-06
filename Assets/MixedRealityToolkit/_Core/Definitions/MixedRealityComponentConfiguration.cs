﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.﻿

using Microsoft.MixedReality.Toolkit.Core.Attributes;
using Microsoft.MixedReality.Toolkit.Core.Definitions.Utilities;
using Microsoft.MixedReality.Toolkit.Core.Interfaces;
using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Core.Definitions
{
    /// <summary>
    /// Defines a system, feature, or manager to be registered with the <see cref="IMixedRealityManager"/> on startup.
    /// </summary>
    [Serializable]
    public struct MixedRealityComponentConfiguration
    {
        [SerializeField]
        [Implements(typeof(IMixedRealityManager), TypeGrouping.ByNamespaceFlat)]
        private SystemType componentType;

        /// <summary>
        /// The concrete type for the system, feature or manager.
        /// </summary>
        public SystemType ComponentType => componentType;

        [SerializeField]
        private string componentName;

        /// <summary>
        /// The simple, human readable name for the system, feature, or manager.
        /// </summary>
        public string ComponentName => componentName;

        [SerializeField]
        private uint priority;

        /// <summary>
        /// The priority this system, feature, or manager will be initialized in.
        /// </summary>
        public uint Priority => priority;

        [EnumFlags]
        [SerializeField]
        private RuntimePlatform runtimePlatform;

        /// <summary>
        /// The runtime platform(s) to run this system, feature, or manager on.
        /// </summary>
        public RuntimePlatform RuntimePlatform => runtimePlatform;

        [SerializeField]
        private ScriptableObject configurationProfile;

        /// <summary>
        /// The configuration profile for the system, feature, or manager.
        /// </summary>
        public ScriptableObject ConfigurationProfile => configurationProfile;

#if UNITY_EDITOR
        [EnumFlags]
        [SerializeField]
        private UnityEditor.BuildTarget editorPlatform;

        /// <summary>
        /// The editor platform(s) to run this system, feature, or manager on.
        /// </summary>
        public UnityEditor.BuildTarget EditorPlatform => editorPlatform;
#endif
    }
}