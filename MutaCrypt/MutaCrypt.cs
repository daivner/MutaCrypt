using System;

namespace MutaCrypt {
    class MutaCrypt {

        private Byte[] _Key;

        private bool _UseSwitch;
        private bool _UseSumFact;

        private UInt64 _KeyLenght;
        private UInt64 _KeyByteIndex;
        private byte _KeyTotal;


        /// <summary>
        /// Calculate the sum from all the bytes from the key
        /// </summary>
        private void _ReloadKeyTotal() {
            for (UInt64 i = 0; i < _KeyLenght; i++) {
                _KeyTotal = (byte)((_KeyTotal + _Key[i]) % 255);
            }
        }

        /// <summary>
        /// Use the sum of the key in each byte of the key
        /// </summary>
        private void _ReloadKeyWithTotal() {
            for (UInt64 i = 0; i < _KeyLenght; i++) {
                _Key[i] = (byte)((_Key[i] + _KeyTotal) % 255);
            }
        }

        /// <summary>
        /// Increase the index from the key array, to use the next byte from the key
        /// </summary>
        private void _NextIndex() {
            _KeyByteIndex++;
            if (_KeyByteIndex == _KeyLenght)
                _KeyByteIndex = 0;                
        }

        /// <summary>
        /// This funcion moves the key bytes each time the key is complete used
        /// </summary>
        private void _SwitchKey() {
            byte _Tmp = _Key[0];
            for (UInt64 i = 0; i < _KeyLenght - 1; i++) {
                _Key[i] = _Key[i + 1];
            }
            _Key[_KeyLenght - 1] = _Tmp;
        }

        // Private internal functions
        //--------------------------------------------------------------
        // Public user functions

        /// <summary>
        /// Create an intance for MutaCrypt
        /// </summary>
        /// <param name="Key">Those bytes are going to be used to crypt the data</param>
        /// <param name="UseSwitch">Enable funcion that moves the key bytes each time the key is complete used</param>
        /// <param name="UseSumFact">Enable the use of the sum of the key in each byte of the key</param>
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

        /// <summary>
        /// Takes the string given and return an array, each byte per char
        /// </summary>
        /// <param name="String">byte array for the string given</param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string String) {
            byte[] _Bytes = new byte[String.Length];
            for (int i = 0; i < String.Length; i++) {
                _Bytes[i] = (byte)String[i];
            }
            return _Bytes;
        }

        /// <summary>
        /// Crypt the byte given By Right
        /// </summary>
        /// <param name="_Byte"></param>
        /// <returns>Byte crypted by Right Function</returns>
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

        /// <summary>
        /// Crypt the byte given by Left
        /// </summary>
        /// <param name="_Byte"></param>
        /// <returns>Byte crypted by Left Function</returns>
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
