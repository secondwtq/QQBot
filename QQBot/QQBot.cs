﻿using QQBot.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace QQBot {
    class QQBot {
        private byte[] tlv0105 = ByteHelper.MergeByteArray(new byte[] { 0x01, 0x05, 0x00, 0x30, 0x00, 0x01, 0x01, 0x02, 0x00, 0x14, 0x01, 0x01, 0x00, 0x10 }, ByteHelper.GetRandomBytes(16), new byte[] { 0x00, 0x14, 0x01, 0x02, 0x00, 0x10 }, ByteHelper.GetRandomBytes(16));



    }
}