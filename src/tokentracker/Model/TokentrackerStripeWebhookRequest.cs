/*
 * Token Tracker Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = tokentracker.Client.OpenAPIDateConverter;

namespace tokentracker.Model
{
    /// <summary>
    /// TokentrackerStripeWebhookRequest
    /// </summary>
    [DataContract(Name = "tokentrackerStripeWebhookRequest")]
    public partial class TokentrackerStripeWebhookRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokentrackerStripeWebhookRequest" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="account">account.</param>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="created">created.</param>
        /// <param name="id">id.</param>
        /// <param name="livemode">livemode.</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="pendingWebhooks">pendingWebhooks.</param>
        /// <param name="request">request.</param>
        /// <param name="type">type.</param>
        public TokentrackerStripeWebhookRequest(StripeEventData data = default(StripeEventData), string account = default(string), string apiVersion = default(string), string created = default(string), string id = default(string), bool livemode = default(bool), string varObject = default(string), string pendingWebhooks = default(string), StripeEventRequest request = default(StripeEventRequest), string type = default(string))
        {
            this.Data = data;
            this.Account = account;
            this.ApiVersion = apiVersion;
            this.Created = created;
            this.Id = id;
            this.Livemode = livemode;
            this.VarObject = varObject;
            this.PendingWebhooks = pendingWebhooks;
            this.Request = request;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public StripeEventData Data { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "apiVersion", EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string VarObject { get; set; }

        /// <summary>
        /// Gets or Sets PendingWebhooks
        /// </summary>
        [DataMember(Name = "pendingWebhooks", EmitDefaultValue = false)]
        public string PendingWebhooks { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public StripeEventRequest Request { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokentrackerStripeWebhookRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  PendingWebhooks: ").Append(PendingWebhooks).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}