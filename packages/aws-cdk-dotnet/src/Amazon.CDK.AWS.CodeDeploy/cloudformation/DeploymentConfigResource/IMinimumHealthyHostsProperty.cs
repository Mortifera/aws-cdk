using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.CodeDeploy.cloudformation.DeploymentConfigResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html </remarks>
    [JsiiInterface(typeof(IMinimumHealthyHostsProperty), "@aws-cdk/aws-codedeploy.cloudformation.DeploymentConfigResource.MinimumHealthyHostsProperty")]
    public interface IMinimumHealthyHostsProperty
    {
        /// <summary>``DeploymentConfigResource.MinimumHealthyHostsProperty.Type``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts-type </remarks>
        [JsiiProperty("type", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Type
        {
            get;
            set;
        }

        /// <summary>``DeploymentConfigResource.MinimumHealthyHostsProperty.Value``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts-value </remarks>
        [JsiiProperty("value", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Value
        {
            get;
            set;
        }
    }
}