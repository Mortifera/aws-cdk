using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Amazon.CDK.AWS.Glue.cloudformation.TableResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html </remarks>
    public class StorageDescriptorProperty : DeputyBase, Amazon.CDK.AWS.Glue.cloudformation.TableResource.IStorageDescriptorProperty
    {
        /// <summary>``TableResource.StorageDescriptorProperty.BucketColumns``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-bucketcolumns </remarks>
        [JsiiProperty("bucketColumns", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}", true)]
        public object BucketColumns
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.Columns``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-columns </remarks>
        [JsiiProperty("columns", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-glue.cloudformation.TableResource.ColumnProperty\"}]}}}}]},\"optional\":true}", true)]
        public object Columns
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.Compressed``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-compressed </remarks>
        [JsiiProperty("compressed", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Compressed
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.InputFormat``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-inputformat </remarks>
        [JsiiProperty("inputFormat", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object InputFormat
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.Location``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-location </remarks>
        [JsiiProperty("location", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Location
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.NumberOfBuckets``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-numberofbuckets </remarks>
        [JsiiProperty("numberOfBuckets", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object NumberOfBuckets
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.OutputFormat``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-outputformat </remarks>
        [JsiiProperty("outputFormat", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object OutputFormat
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.Parameters``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-parameters </remarks>
        [JsiiProperty("parameters", "{\"union\":{\"types\":[{\"primitive\":\"json\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Parameters
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.SerdeInfo``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-serdeinfo </remarks>
        [JsiiProperty("serdeInfo", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-glue.cloudformation.TableResource.SerdeInfoProperty\"}]},\"optional\":true}", true)]
        public object SerdeInfo
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.SkewedInfo``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-skewedinfo </remarks>
        [JsiiProperty("skewedInfo", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-glue.cloudformation.TableResource.SkewedInfoProperty\"}]},\"optional\":true}", true)]
        public object SkewedInfo
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.SortColumns``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-sortcolumns </remarks>
        [JsiiProperty("sortColumns", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-glue.cloudformation.TableResource.OrderProperty\"}]}}}}]},\"optional\":true}", true)]
        public object SortColumns
        {
            get;
            set;
        }

        /// <summary>``TableResource.StorageDescriptorProperty.StoredAsSubDirectories``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-storedassubdirectories </remarks>
        [JsiiProperty("storedAsSubDirectories", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object StoredAsSubDirectories
        {
            get;
            set;
        }
    }
}