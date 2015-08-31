using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.IO;
using Ionic.Zip;
using System.Collections;

namespace TIS.Client
{
    public class ZipFile
    {
        // Fields
        private byte[] BIN;
        public Collection Files = new Collection();
        private MemoryStream MS;
        public MemoryStream OMS;
        private string Pass;

        // Methods
        public void Dissect()
        {
            byte[] buffer = new byte[0x800];
            using (ZipInputStream stream2 = new ZipInputStream(this.MS))
            {
                for (ZipEntry entry = stream2.GetNextEntry(); entry != null; entry = stream2.GetNextEntry())
                {
                    if (!entry.IsDirectory)
                    {
                        ZipFileEntry item = new ZipFileEntry
                        {
                            Name = entry.FileName
                        };
                        MemoryStream stream = new MemoryStream();
                        if (Strings.Len(this.Pass) > 0)
                        {
                            stream2.Password = this.Pass;
                        }
                        if (entry.UncompressedSize > 0L)
                        {
                            for (int i = stream2.Read(buffer, 0, buffer.Length); i > 0; i = stream2.Read(buffer, 0, buffer.Length))
                            {
                                stream.Write(buffer, 0, i);
                            }
                        }
                        item.contents = stream.ToArray();
                        this.Files.Add(item, null, null, null);
                    }
                    else
                    {
                        ZipFileEntry entry3 = new ZipFileEntry
                        {
                            IsDir = true,
                            Name = entry.FileName
                        };
                    }
                }
            }
        }

        public void MakeZipFile(string fn, string Password = "")
        {
            this.MakeZipStream("");
            ToFile(fn, this.OMS.ToArray());
        }

        public void MakeZipStream(string Password = "")
        {
            if (this.Files.Count != 0)
            {
                this.OMS = new MemoryStream();
                using (ZipOutputStream stream = new ZipOutputStream(this.OMS))
                {
                    IEnumerator enumerator;
                    if (Strings.Len(Password) > 0)
                    {
                        stream.Password = this.Pass;
                        stream.Encryption = EncryptionAlgorithm.WinZipAes256;
                    }
                    try
                    {
                        enumerator = this.Files.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            ZipFileEntry current = (ZipFileEntry)enumerator.Current;
                            if (current.IsDir)
                            {
                                stream.PutNextEntry(current.Name + "/");
                            }
                            else
                            {
                                stream.PutNextEntry(current.Name);
                                if (current.contents.Length > 0)
                                {
                                    stream.Write(current.contents, 0, current.contents.Length);
                                }
                            }
                        }
                    }
                    finally
                    {
                    }
                }
            }
        }

        public void Open(byte[] Content, string password = "")
        {
            this.BIN = Content;
            this.Pass = password;
            this.MS = new MemoryStream(this.BIN);
            this.Dissect();
        }

        public void Open(string FN, string password = "")
        {
            this.BIN = ReadBytesFromFile(FN);
            this.Open(this.BIN, password);
        }

        public static void ToFile(string Filename, byte[] contentsB)
        {
            FileStream output = new FileStream(Filename, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(output);
            writer.BaseStream.Seek(0L, SeekOrigin.Begin);
            writer.Write(contentsB);
            writer.Flush();
            output.Flush();
            writer.Close();
            writer = null;
            output.Close();
            output.Dispose();
        }

        public static byte[] ReadBytesFromFile(string Filename)
        {
            FileStream input = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(input);
            reader.BaseStream.Seek(0L, SeekOrigin.Begin);
            byte[] buffer = reader.ReadBytes((int)input.Length);
            reader.Close();
            input.Close();
            return buffer;
        }

 


 


    }
}
