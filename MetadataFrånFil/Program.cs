int[] pngHeader = new int[] { 137, 80, 78, 71, 13, 10, 26, 10 };
int[] bmpHeader = new int[] { 66, 77 };

using (FileStream stream = File.OpenRead("bitmap.bmp"))
{
    byte[] data = new byte[26];
    stream.Read(data,0, 26);

    int[] dataPNGHeader = data.Take(8).Select(b => (int)b).ToArray();
    int[] dataBMPHeader = data.Take(2).Select(b => (int)b).ToArray();

    if (dataPNGHeader.SequenceEqual(pngHeader))
    {

        uint width = (uint)((data[16] << 24) | (data[17] << 16) | (data[18] << 8) | data[19]);
        uint height = (uint)((data[20] << 24) | (data[21] << 16) | (data[22] << 8) | data[23]);

        Console.WriteLine($"The file is a .PNG with a width of {width} pixles and a height of {height} pixles.");
    }
    else if (dataBMPHeader.SequenceEqual(bmpHeader))
    {
        uint width = (uint)(data[18] | (data[19] << 8) | (data[20] << 16) | (data[21] << 24));
        uint height = (uint)(data[22] | (data[23] << 8) | (data[24] << 16) | (data[25] << 24));

        Console.WriteLine($"The file is a .BMP with a width of {width} pixels and a height of {height} pixels.");
    }
    else
    {
        Console.WriteLine("This is not a valid .bmp or .png file!");
    }
}
