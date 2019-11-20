/***************************************************************
 * File: Images.cs
 * Created By: Syed Ghulam Akbar		Date: 28 June, 2005
 * Description: This class loads all the images from the disk to 
 * an internal image list and support methods to get images by either
 * piece type or image name
 ***************************************************************/

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using ChessLibrary;

namespace Chess
{
    /// <summary>
    /// Summary description for Images.
    /// </summary>
    public class DCImages : Images
    {
        public DCImages()
        {
            m_ImageList = new ArrayList();
        }

        public override void LoadImages(string SourceDir)
        {

            // Read and store the image black and white image paths
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "Black.jpg"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "White.jpg"));
            // Read and store the white pieces images
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "batman.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "superman.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "green_lantern.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "shazam.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "flash.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "pawn.gif"));
            // Read and store the black pieces images
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "joker.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "bane.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "riddler.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "poison_ivy.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "harley_quinn.png"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "pawn_2.gif"));
            // Read and store the image black and white image paths
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "Black_2.jpg"));
            m_ImageList.Add(System.Drawing.Image.FromFile(SourceDir + "White_2.jpg"));
        }
    }
}