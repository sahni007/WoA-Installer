﻿using System;

namespace Installer.Core
{
    public class Partition
    {
        public Disk Disk { get; set; }
        public uint Number { get; set; }
        public string Id { get; set; }
        public char Letter { get; set; }
        public Guid? GptType { get; set; }
    }
}