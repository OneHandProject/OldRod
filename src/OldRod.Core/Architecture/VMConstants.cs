using System.Collections.Generic;
using AsmResolver.Net.Cts;

namespace OldRod.Core.Architecture
{
    public class VMConstants
    {
        public IDictionary<FieldDefinition, byte> ConstantFields
        {
            get;
        } = new Dictionary<FieldDefinition, byte>();
        
        public IDictionary<byte, ILCode> OpCodes
        {
            get;
        } = new Dictionary<byte, ILCode>();
        
        public IDictionary<byte, VMFlags> Flags
        {
            get;
        } = new Dictionary<byte, VMFlags>();
        
        public IDictionary<byte, VMRegisters> Registers
        {
            get;
        } = new Dictionary<byte, VMRegisters>();
        
        public IDictionary<byte, VMCalls> VMCalls
        {
            get;
        } = new Dictionary<byte, VMCalls>();
    }
}