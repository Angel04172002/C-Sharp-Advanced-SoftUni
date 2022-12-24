namespace ExtractBytes
{
    using System;
    using System.IO;
    public class ExtractBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        { 
            using(FileStream binaryFile = new FileStream(binaryFilePath, FileMode.Open))
            {
                using(FileStream image = new FileStream(bytesFilePath, FileMode.Open))
                {
                    byte[] binaryFileArr = new byte[binaryFile.Length];
                    binaryFile.Read(binaryFileArr, 0, binaryFileArr.Length);

                    byte[] imageArr = new byte[image.Length];   
                    image.Read(imageArr, 0, imageArr.Length);   

                    using(FileStream writer = new FileStream(outputPath, FileMode.Create))
                    {
                        
                        for(int i = 0; i < imageArr.Length; i++)
                        {
                            for(int k = 0; k < binaryFileArr.Length; k++)
                            {
                                if (imageArr[i] == binaryFileArr[k])
                                {
                                    writer.Write(new byte[] { imageArr[i] });
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
