

using System; 
using System.ComponentModel; 
using System.Drawing; 
using System.Reflection; 
using System.Windows.Forms; 

namespace Saraff.Twain 
{ 
    // Summary: 
    // Provides the ability to work with TWAIN-sources. 
    [ToolboxBitmap (typeof (Twain32), "Resources.scanner.bmp")] 
    [DefaultProperty ("AppProductName")] 
    [DefaultEvent ("AcquireCompleted")] 
    public sealed class Twain32: Component 
    { 
        // Summary: 
        // Initializes a new instance of the Saraff.Twain.Twain32 class. 
        public Twain32 (); 
        // 
        // Summary: 
        // Initializes a new instance of the Saraff.Twain.Twain32 class. 
        // 
        // Parameters: 
        // Container: 
        // The container. 
        public Twain32 (IContainer container); 

        // Summary: 
        // Gets or sets the application name. 
        [Category ("Behavior")] 
        [Description ("Gets or sets the name of the application.")] 
        public string AppProductName {get; set;} 
        // 
        // Summary: 
        // Gets or sets a value that indicates whether to deactivate 
        // Data source after receiving the image. 
        [DefaultValue (true)] 
        [Category ("Behavior")] 
        [Description ("Gets or sets a value indicating whether the data source is deactivated after receiving the image.")] 
        public bool DisableAfterAcquire {get; set;} 
        // 
        // Summary: 
        // Returns the number of scanned images. 
        [Browsable (false)] 
        public int ImageCount {get;} 
        // 
        // Summary: 
        // Gets or sets the physical location of the image frame. 
        [ReadOnly (true)] 
        [Browsable (false)] 
        public RectangleF ImageLayout {get; set;} 
        // 
        // Summary: 
        // Gets or sets the parent window for TWAIN-source. 
        [DefaultValue (false)] 
        [Description ("Gets or sets the parent window for TWAIN-source.")] 
        [Category ("Behavior")] 
        public IWin32Window Parent {get; set;} 
        // 
        // Summary: 
        // Gets or sets a value indicating whether to show 
        // UI TWAIN-source. 
        [DefaultValue (true)] 
        [Category ("Behavior")] 
        [Description ("Gets or sets a value indicating whether to display the UI TWAIN-source.")] 
        public bool ShowUI {get; set;} 
        // 
        // Summary: 
        // Gets or sets the index of the current data source. 
        [ReadOnly (true)] 
        [Browsable (false)] 
        public int SourceIndex {get; set;} 
        // 
        // Summary: 
        // Returns the number of data sources. 
        [Browsable (false)] 
        public int SourcesCount {get;} 

        // Summary: 
        // Occurs when the scan is finished. 
        [Description ("Occurs when the scan is finished.")] 
        [Category ("Action")] 
        public event EventHandler AcquireCompleted; 
        // 
        // Summary: 
        // There is at the moment the image acquisition. 
        [Description ("There is at the moment the image acquisition.")] 
        [Category ("Action")] 
        public event EventHandler <Twain32.EndXferEventArgs> EndXfer; 
        // 
        // Summary: 
        // Occurs when the state changes twain-device. 
        [Category ("Action")] 
        [Description ("Occurs when the state changes twain-device.")] 
        public event EventHandler <Twain32.TwainStateEventArgs> TwainStateChanged; 

        // Summary: 
        // Get the image from the data source. 
        public void Acquire (); 
        // 
        // Summary: 
        // Closes the data source. 
        // 
        // Returns: 
        // True if the operation was successful, otherwise false. 
        public bool CloseDataSource (); 
        // 
        // Summary: 
        // Closes menezher data sources. 
        // 
        // Returns: 
        // True if the operation was successful, otherwise false. 
        public bool CloseDSM (); 
        // 
        // Summary: 
        // Releases the unmanaged resources used by the System.ComponentModel.Component 
        // And optionally releases the managed resources. 
        // 
        // Parameters: 
        // Disposing: 
        // True to release both managed and unmanaged resources; false to release only 
        // Unmanaged resources. 
        protected override void Dispose (bool disposing); 
        // 
        // Summary: 
        // Returns the value for the specified capability (opportunity). 
        // 
        // Parameters: 
        // Capability: 
        // Enumeration value TwCap. 
        // 
        // Returns: 
        // Depending on the value of capability, can be returned: value type, 
        // Array, Saraff.Twain.Twain32.Range, Saraff.Twain.Twain32.Enumeration. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public object GetCap (TwCap capability); 
        // 
        // Summary: 
        // Returns otskanirovanoe image. 
        // 
        // Parameters: 
        // Index: 
        // Index of the image. 
        // 
        // Returns: 
        // A copy of the image. 
        public Image GetImage (int index); 
        // 
        // Summary: 
        // Returns the pixels types supported by the data source. 
        // 
        // Returns: 
        // Collection of values. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public Twain32.Enumeration GetPixelTypes (); 
        // 
        // Summary: 
        // Returns the resolutions supported by the data source. 
        // 
        // Returns: 
        // Collection of values. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public Twain32.Enumeration GetResolutions (); 
        // 
        // Summary: 
        // Returns the name of the data source at the specified index. 
        // 
        // Parameters: 
        // Index: 
        // Index. 
        // 
        // Returns: 
        // Name of the data source. 
        public string GetSourceProductName (int index); 
        // 
        // Summary: 
        // Returns the units of measurement used data source. 
        // 
        // Returns: 
        // Units. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public Twain32.Enumeration GetUnitOfMeasure (); 
        // 
        // Summary: 
        // Returns flags indicating the supported data source operations 
        // For the specified capability. 
        // 
        // Parameters: 
        // Capability: 
        // Value perechisdeniya TwCap. 
        // 
        // Returns: 
        // Set of flags. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public TwQC IsCapSupported (TwCap capability); 
        // 
        // Summary: 
        // Open the data source. 
        // 
        // Returns: 
        // True if the operation was successful, otherwise false. 
        public bool OpenDataSource (); 
        // 
        // Summary: 
        // Opens the Data Sources manager. 
        // 
        // Returns: 
        // True if the operation was successful, otherwise false. 
        public bool OpenDSM (); 
        // 
        // Summary: 
        // Display a dialog box to select a data source. 
        // 
        // Returns: 
        // True if the operation was successful, otherwise false. 
        public bool SelectSource (); 
        // 
        // Summary: 
        // Sets the value for the specified Saraff.Twain.TwCap 
        // 
        // Parameters: 
        // Capability: 
        // Enumeration value Saraff.Twain.TwCap. 
        // 
        // Value: 
        // Set value. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public void SetCap (TwCap capability, object value); 
        // 
        // Summary: 
        // Sets the value for the specified Saraff.Twain.TwCap 
        // 
        // Parameters: 
        // Capability: 
        // Enumeration value Saraff.Twain.TwCap. 
        // 
        // CapabilityValue: 
        // Set value. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public void SetCap (TwCap capability, object [] capabilityValue); 
        // 
        // Summary: 
        // Sets the value for the specified Saraff.Twain.TwCap 
        // 
        // Parameters: 
        // Capability: 
        // Enumeration value Saraff.Twain.TwCap. 
        // 
        // CapabilityValue: 
        // Set value. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public void SetCap (TwCap capability, Twain32.Enumeration capabilityValue); 
        // 
        // Summary: 
        // Sets the value for the specified Saraff.Twain.TwCap 
        // 
        // Parameters: 
        // Capability: 
        // Enumeration value Saraff.Twain.TwCap. 
        // 
        // CapabilityValue: 
        // Set value. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public void SetCap (TwCap capability, Twain32.Range capabilityValue); 
        // 
        // Summary: 
        // Sets the current type of pixels. 
        // 
        // Parameters: 
        // Value: 
        // Type of pixels. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public void SetPixelType (TwPixelType value); 
        // 
        // Summary: 
        // Sets the current resolution. 
        // 
        // Parameters: 
        // Value: 
        // Enable. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public void SetResolutions (float value); 
        // 
        // Summary: 
        // Sets the current unit of measure used data source. 
        // 
        // Parameters: 
        // Value: 
        // Unit. 
        // 
        // Exceptions: 
        // Saraff.Twain.TwainException: 
        // Raised when an error occurs during the operation. 
        public void SetUnitOfMeasure (TwUnits value); 
        // 
        // Summary: 
        // Returns a System.String that represents this instance. 
        // 
        // Returns: 
        // A System.String that represents this instance. 
        public override string ToString (); 

        // Summary: 
        // Status flags. 
        [Flags] 
        public enum TwainStateFlag 
        { 
            DSMOpen = 1 ,
            DSOpen = 2, 
            DSEnabled = 4, 
        } 

        // Summary: 
        // Event arguments EndXfer. 
        public sealed class EndXferEventArgs: EventArgs 
        { 
            // Summary: 
            // Returns the image. 
            public Image Image {get;} 
        } 

        // Summary: 
        // Enumeration. 
        public sealed class Enumeration 
        { 
            // Summary: 
            // Returns the number of elements. 
            public int Count {get;} 
            // 
            // Summary: 
            // Returns the current index. 
            public int CurrentIndex {get;} 
            // 
            // Summary: 
            // Returns the index of the default. 
            public int DefaultIndex {get;} 

            // Summary: 
            // Returns the element at the specified index. 
            // 
            // Parameters: 
            // Index: 
            // Index. 
            // 
            // Returns: 
            // The element at the specified index. 
            public object this [int index] {get;} 

            // Summary: 
            // Creates and returns an instance Saraff.Twain.Twain32.Enumeration. 
            // 
            // Parameters: 
            // Items: 
            // Elements of the enumeration. 
            // 
            // CurrentIndex: 
            // Current index. 
            // 
            // DefaultIndex: 
            // Default Index. 
            // 
            // Returns: 
            // Instance Saraff.Twain.Twain32.Enumeration. 
            public static Twain32.Enumeration CreateEnumeration (object [] items, int currentIndex, int defaultIndex); 
            // 
            // Summary: 
            // Creates and returns an instance Saraff.Twain.Twain32.Enumeration. 
            // 
            // Parameters: 
            // Value: 
            // Array of values. 
            // 
            // Returns: 
            // Instance Saraff.Twain.Twain32.Enumeration. 
            public static Twain32.Enumeration FromArray (object [] value); 
            // 
            // Summary: 
            // Creates and returns an instance Saraff.Twain.Twain32.Enumeration. 
            // 
            // Parameters: 
            // Value: 
            // Value. 
            // 
            // Returns: 
            // Instance Saraff.Twain.Twain32.Enumeration. 
            public static Twain32.Enumeration FromOneValue (ValueType value); 
            // 
            // Summary: 
            // Creates and returns an instance Saraff.Twain.Twain32.Enumeration. 
            // 
            // Parameters: 
            // Value: 
            // Instance Saraff.Twain.Twain32.Range. 
            // 
            // Returns: 
            // Instance Saraff.Twain.Twain32.Enumeration. 
            public static Twain32.Enumeration FromRange (Twain32.Range value); 
        } 

        // Summary: 
        // Range of values. 
        public sealed class Range 
        { 
            // Summary: 
            // Gets or sets the current value. 
            public object CurrentValue {get; set;} 
            // 
            // Summary: 
            // Gets or sets a significant default. 
            public object DefaultValue {get; set;} 
            // 
            // Summary: 
            // Gets or sets the maximum value. 
            public object MaxValue {get; set;} 
            // 
            // Summary: 
            // Gets or sets the minimum value. 
            public object MinValue {get; set;} 
            // 
            // Summary: 
            // Gets or sets the step. 
            public object StepSize {get; set;} 

            // Summary: 
            // Creates and returns an instance Saraff.Twain.Twain32.Range. 
            // 
            // Parameters: 
            // MinValue: 
            // Minimum value. 
            // 
            // MaxValue: 
            // Maximum value. 
            // 
            // StepSize: 
            // Step. 
            // 
            // DefaultValue: 
            // Default value. 
            // 
            // CurrentValue: 
            // Current value. 
            // 
            // Returns: 
            // Instance Saraff.Twain.Twain32.Range. 
            public static Twain32.Range CreateRange (object minValue, object maxValue, object stepSize, object defaultValue, object currentValue); 
        } 

        // Summary: 
        // Event arguments TwainStateChanged. 
        public sealed class TwainStateEventArgs: EventArgs 
        { 
            // Summary: 
            // Initializes a new instance of the class. 
            // 
            // Parameters: 
            // Flags: 
            // Status flags. 
            public TwainStateEventArgs (Twain32.TwainStateFlag flags); 

            // Summary: 
            // Returns the status flags twain-device. 
            public Twain32.TwainStateFlag TwainState {get;} 
        } 
    } 
} 
