using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * @author  : Lasitha Ishan Petthawadu
 * @date    : 23/02/2014
 */
namespace SVGSample
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmSVGWindow : Form
    {

        /// <summary>
        /// The file path of the SVG image selected.
        /// </summary>
        private string selectedPath;

        /// <summary>
        /// Instance reference for the svgDocument used and updated throughout the manipulation of the image.
        /// </summary>
        private Svg.SvgDocument svgDocument;
        
        /// <summary>
        /// Form window constructor.
        /// </summary>
        public frmSVGWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Action responsible to allow the user select a SVG image.
        /// </summary>
        /// <param name="sender">The source calling the event.</param>
        /// <param name="e">The arguments passed to the event.</param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult selectResult = filePicker.ShowDialog();
            if (selectResult == System.Windows.Forms.DialogResult.OK)
            {
                svg.SVGParser.MaximumSize = new Size(pictConvertedImage.Width, pictConvertedImage.Height);
                
                selectedPath = filePicker.FileName;
                txtSelectedFile.Text = selectedPath;
                svgDocument = svg.SVGParser.GetSvgDocument(selectedPath);
               
                txtWidth.Text = svgDocument.Width.Value.ToString();
                txtHeight.Text = svgDocument.Height.Value.ToString(); 
                
                pictConvertedImage.Image = svg.SVGParser.GetBitmapFromSVG(selectedPath);
            }
        }

        /// <summary>
        /// Action responsible to allow the user pick a source color. 
        /// </summary>
        /// <param name="sender">The source calling the event.</param>
        /// <param name="e">The arguments passed to the event.</param>
        private void btnSourceColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
        }

        /// <summary>
        /// Destination Color Selection
        /// </summary>
        /// <param name="sender">The source calling the event.</param>
        /// <param name="e">The arguments passed to the event.</param>
        private void btnDestination_Click(object sender, EventArgs e)
        {
            DialogResult result = colorPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnDestinationColor.BackColor = colorPicker.Color;
            }
        }

        /// <summary>
        /// Action responsible to replace the color of the original image.
        /// </summary>
        /// <param name="sender">The source calling the event.</param>
        /// <param name="e">The arguments passed to the event.</param>
        private void btnReplaceColor_Click(object sender, EventArgs e)
        {
            if (!ValidateFormControls())
                return;

            foreach (Svg.SvgElement item in svgDocument.Children)
            {
                ChangeFill(item, btnSourceColor.BackColor, btnDestinationColor.BackColor);
            }
            pictConvertedImage.Image = svgDocument.Draw();
        }

        /// <summary>
        ///  Recursive fill function to change the color of a selected node and all of its children.
        /// </summary>
        /// <param name="element">The current element been resolved.</param>
        /// <param name="sourceColor">The source color to search for.</param>
        /// <param name="replaceColor">The color to be replaced the source color with.</param>
        private void ChangeFill(SvgElement element, Color sourceColor, Color replaceColor)
        {
            if (element is SvgPath)
            {
                if (((element as SvgPath).Fill as SvgColourServer).Colour.ToArgb() == sourceColor.ToArgb())
                {
                    (element as SvgPath).Fill = new SvgColourServer(replaceColor);
                }
            }

            if (element.Children.Count > 0)
            {
                foreach (var item in element.Children)
                {
                    ChangeFill(item, sourceColor, replaceColor);
                }
            }

        }
                     
        /// <summary>
        /// Action used to pick the color from a pixel from the rasterized picture.
        /// </summary>
        /// <param name="sender">The source calling the event.</param>
        /// <param name="e">The arguments passed to the event.</param>
        private void pictConvertedImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (togglePickColor.Checked)
            {
                if (!ValidateFormControls())
                    return;


                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Bitmap bmp = pictConvertedImage.Image as Bitmap;
                    btnSourceColor.BackColor = bmp.GetPixel(e.X, e.Y);

                }
            }
        }

        /// <summary>
        /// Action used to scale down an SVG image. (in inrements of 10)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScaleDown_Click(object sender, EventArgs e)
        {
            if (!ValidateFormControls())
                return;

            int W =int.Parse(txtWidth.Text);
            int H = int.Parse(txtHeight.Text);

            if (W - 10 > 0 &&  H- 10 > 0)
            {
                W -= 10;
                txtWidth.Text = W.ToString();

                H -= 10;
                txtHeight.Text = H.ToString();

                svgDocument.Width = W;
                svgDocument.Height = H;

                pictConvertedImage.Image = svgDocument.Draw();
            }
        }

        /// <summary>
        /// Action used to scale up an SVG image. (in inrements of 10)
        /// </summary>
        /// <param name="sender">The source calling the event.</param>
        /// <param name="e">The arguments passed to the event.</param>
        private void btnScaleUp_Click(object sender, EventArgs e)
        {
            if (!ValidateFormControls())
                return;

            int W = int.Parse(txtWidth.Text);
            int H = int.Parse(txtHeight.Text);

            if (W + 10 < pictConvertedImage.Width && H + 10 < pictConvertedImage.Height)
            {
                W += 10;
                txtWidth.Text = W.ToString();

                H += 10;
                txtHeight.Text = H.ToString();

                svgDocument.Width = W;
                svgDocument.Height = H;

                pictConvertedImage.Image = svgDocument.Draw();
            }
        }

        /// <summary>
        /// Checks if there is an image selected.
        /// </summary>
        /// <returns>Returns the boolean results whether an image is selected.</returns>
        private bool ValidateFormControls()
        {
            if (svgDocument == null || pictConvertedImage.Image == null)
            {
                MessageBox.Show("Please select a SVG image to continue");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Action performed to indicate whether picking color from the image is available.
        /// </summary>
        /// <param name="sender">The source calling the event.</param>
        /// <param name="e">The arguments passed to the event.</param>
        private void togglePickColor_CheckedChanged(object sender, EventArgs e)
        {
            if (togglePickColor.Checked)
            {
                togglePickColor.BackColor = Color.LightPink;
                pictConvertedImage.Cursor = Cursors.Cross;
            }
            else
            {
                togglePickColor.BackColor = Color.Gainsboro;
                pictConvertedImage.Cursor = Cursors.Default;
            }
        }
  
    }
}
