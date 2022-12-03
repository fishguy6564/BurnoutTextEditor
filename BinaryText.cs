using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnoutLegendsTextEditor
{
    class BinaryText
    {
        private uint entries;
        private uint headerSize;
        private int fileMagic1;
        private int fileMagic2;
        private ArrayList textStrings;

        public BinaryText()
        {
            this.entries = 0;
            this.headerSize = 0;
            this.fileMagic1 = 0;
            this.fileMagic2 = 0;
            this.textStrings = new ArrayList();
        }

        public void clear()
        {
            this.entries = 0;
            this.headerSize = 0;
            this.fileMagic1 = 0;
            this.fileMagic2 = 0;
            this.textStrings = new ArrayList();
        }

        //Grabs necessary information from the raw binary of the header 
        private void interpretHeader(byte[] inputBytes)
        {
            this.fileMagic1 = BitConverter.ToInt32(inputBytes, 0);
            this.fileMagic2 = BitConverter.ToInt32(inputBytes, 4);
            this.entries = BitConverter.ToUInt32(inputBytes, 8);
            this.headerSize = BitConverter.ToUInt32(inputBytes, 0xC);
        }

        private String interpretStrings(byte[] inputBytes, uint fileOffset)
        {
            String lastChar;
            String accumulator = "";
            byte[] unicodeChar = new byte[2];
            
            while(true)
            {
                Array.Copy(inputBytes, fileOffset, unicodeChar, 0, 2);
                lastChar = Encoding.Unicode.GetString(unicodeChar);

                if (lastChar.Equals("\0")) return accumulator;

                accumulator += lastChar;
                fileOffset += 2;
            }
        }

        private void interpretEntries(byte[] inputBytes)
        {
            String accumulator;
            uint fileOffset;
            int entryOffset = (int)this.headerSize;
            
            for (uint i = 0; i < this.entries; i++)
            {
                fileOffset = BitConverter.ToUInt32(inputBytes, entryOffset);
                accumulator = interpretStrings(inputBytes, fileOffset);
                this.textStrings.Add(accumulator);
                entryOffset += 4;
            }
        }

        private byte[] getIntBytes(int data)
        {
            byte[] intBytes = BitConverter.GetBytes(data);
            if (!BitConverter.IsLittleEndian) Array.Reverse(intBytes);
            return intBytes;
        }

        private byte[] getLongBytes(long data)
        {
            byte[] longBytes = BitConverter.GetBytes(data);
            if (!BitConverter.IsLittleEndian) Array.Reverse(longBytes);
            return longBytes;
        }

        private byte[] combineBytes(byte[][] arrays)
        {
            byte[] accumulator;
            int offset = 0;

            accumulator = new byte[arrays.Sum(a => a.Length)];

            foreach (byte[] array in arrays)
            {
                Buffer.BlockCopy(array, 0, accumulator, offset, array.Length);
                offset += array.Length;
            }

            return accumulator;
        }

        private byte[] constructBinaryHeader()
        {
            byte[][] arrays = new byte[4][];

            arrays[0] = getIntBytes(this.fileMagic1);
            arrays[1] = getIntBytes(this.fileMagic2);
            arrays[2] = getIntBytes((int)this.entries);
            arrays[3] = getIntBytes((int)this.headerSize);

            return combineBytes(arrays);
        }

        private byte[] convertIntArrayToByteArray(int[] data)
        {
            byte[] dataBytes = new byte[0];

            foreach (int value in data)
            {
                byte[] temp = getIntBytes(value);
                byte[][] dataArrays = { dataBytes, temp };

                dataBytes = combineBytes(dataArrays);
            }
            return dataBytes;
        }

        private byte[][] constructBinaryEntries()
        {
            byte[] entryTableBytes;
            byte[] stringBytes = new byte[0];
            int[] entryTable = new int[this.entries];
            int offset = (int)this.headerSize + (int)this.entries * 4;
            int entryIndex = 0;

            UnicodeEncoding unicode = new UnicodeEncoding();

            foreach (String entryString in this.textStrings)
            {
                byte[] temp = unicode.GetBytes(entryString + "\0");
                byte[][] data = { stringBytes, temp };

                stringBytes = combineBytes(data);

                entryTable[entryIndex] = offset;
                offset += temp.Length;
                entryIndex++;
            }

            entryTableBytes = convertIntArrayToByteArray(entryTable);
            byte[][] returnedData = { entryTableBytes, stringBytes };
            return returnedData;
        }

        private byte[] constructBinaryFile()
        {
            byte[] headerBytes;
            byte[][] entryBytes;

            headerBytes = constructBinaryHeader();
            entryBytes = constructBinaryEntries();

            byte[][] fileByteArrays = { headerBytes, entryBytes[0], entryBytes[1] };
            return combineBytes(fileByteArrays);
        }

        //Interprets the raw binary of the file to the object
        private void interpretFile(byte[] inputBytes)
        {
            interpretHeader(inputBytes);
            interpretEntries(inputBytes);
        }

        public uint getMaxEntries()
        {
            return this.entries;
        }

        public String getEntryString(int index)
        {
            return (String)this.textStrings[index];
        }

        public void setEntyString(String s, int index)
        {
            this.textStrings[index] = s;
        }

        public void addEntryString(String s)
        {
            this.textStrings.Add(s);
            this.entries++;
        }

        public void importStrings(String[] stringImports)
        {
            foreach (String s in stringImports) addEntryString(s);
        }

        public void deleteEntry(int index)
        {
            this.textStrings.RemoveAt(index);
            this.entries--;
        }

        public bool openFile(String filepath)
        {
            try
            {
                interpretFile(File.ReadAllBytes(filepath));
                return true;
            }catch(IOException)
            {
                return false;
            }
        }
        public bool saveFile(String filepath)
        {
            byte[] fileBytes;

            fileBytes = constructBinaryFile();

            try
            {
                File.WriteAllBytes(filepath, fileBytes);
                return true;
            }catch(IOException)
            {
                return false;
            }
        }
    }
}
