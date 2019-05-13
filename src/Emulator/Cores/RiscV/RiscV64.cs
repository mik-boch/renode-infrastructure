//
// Copyright (c) 2010-2018 Antmicro
//
// This file is licensed under the MIT License.
// Full license text is available in 'licenses/MIT.txt'.
//
using Antmicro.Renode.Core;
using Antmicro.Renode.Peripherals.Timers;
using Endianess = ELFSharp.ELF.Endianess;

namespace Antmicro.Renode.Peripherals.CPU
{
    public partial class RiscV64 : BaseRiscV
    {
        public RiscV64(IRiscVTimeProvider timeProvider, string cpuType, Machine machine, uint hartId = 0, PrivilegeArchitecture privilegeArchitecture = PrivilegeArchitecture.Priv1_10, Endianess endianness = Endianess.LittleEndian) : base(timeProvider, hartId, cpuType, machine, privilegeArchitecture, endianness, CpuBitness.Bits64)
        {
        }

        public override string Architecture { get { return "riscv64"; } }

        public override string GDBArchitecture { get { return "riscv:rv64"; } }

        private ulong BeforePCWrite(ulong value)
        {
            PCWritten();
            return value;
        }
    }
}
