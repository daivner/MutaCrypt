using System;

namespace MutaCrypt {
    class MutaCrypt {

        private Byte[] _Key;

        private bool _UseSwitch;
        private bool _UseSumFact;

        private UInt64 _KeyLenght;
        private UInt64 _KeyByteIndex;
        private byte _KeyTotal;

        public MutaCrypt(Byte[] Key, bool UseSwitch, bool UseSumFact) {
            if (Key.Length > 0) {
                _Key = Key;
                _UseSumFact = UseSumFact;
                _UseSwitch = UseSwitch;
                _KeyLenght = (UInt64)Key.Length;
                _KeyByteIndex = 0;
                _ReloadKeyTotal();
            }
        }

        public static byte[] StringToByteArray(string String) {
            byte[] _Bytes = new byte[String.Length];
            for (int i = 0; i < String.Length; i++) {
                _Bytes[i] = (byte)String[i];
            }
            return _Bytes;
        } 

        private void _ReloadKeyTotal() {
            for (UInt64 i = 0; i < _KeyLenght; i++) {
                _KeyTotal = (byte)((_KeyTotal + _Key[i]) % 255);
            }
        }

        private void _ReloadKeyWithTotal() {
            for (UInt64 i = 0; i < _KeyLenght; i++) {
                _Key[i] = (byte)((_Key[i] + _KeyTotal) % 255);
            }
        }

        private void _NextIndex() {
            if (_KeyByteIndex + 1 == _KeyLenght)
                _KeyByteIndex = 0;
            else
                _KeyByteIndex++;
        }

        private void _SwitchKey() {
            byte _Tmp = _Key[0];
            for (UInt64 i = 0; i < _KeyLenght - 1; i++) {
                _Key[i] = _Key[i + 1];
            }
            _Key[_KeyLenght - 1] = _Tmp;
        }

        //--------------------------------------------------------------

        public byte OriginalRight(byte _Byte) {
            _Byte = (byte)((_Byte + _Key[_KeyByteIndex]) % 255);
            _NextIndex();
            if (_KeyByteIndex == 0) {
                if (_UseSwitch)
                    _SwitchKey();
                if (_UseSumFact)
                    _ReloadKeyWithTotal();
            }
            return _Byte;
        }

        public byte OriginalLeft(byte _Byte) {
            _Byte = (byte)((_Byte + 510 - _Key[_KeyByteIndex]) % 255);
            _NextIndex();
            if (_KeyByteIndex == 0) {
                if (_UseSwitch)
                    _SwitchKey();
                if (_UseSumFact)
                    _ReloadKeyWithTotal();
            }
            return _Byte;
        }

    }
}
