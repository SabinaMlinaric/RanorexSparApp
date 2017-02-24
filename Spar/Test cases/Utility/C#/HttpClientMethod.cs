/*
 * Created by Ranorex
 * User: sabinam
 * Date: 23. 02. 2017
 * Time: 13:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Spar.Test_cases.Utility
{
	/// <summary>
	/// Description of HttpClient.
	/// </summary>
	public class HttpClientMethod
	{
		public HttpClientMethod()
		{
		}
		
		public static async Task<HttpResponseInfo> GetAsync(string url, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
					

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					var response = client.GetAsync(url).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		public static async Task<HttpResponseInfo> GetAsync(string url, List<CustomHeaders> customHeaderList, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					if (customHeaderList.Count > 0)
					{
						foreach (CustomHeaders header in customHeaderList)
						{
							if (string.IsNullOrEmpty(header.Value))
							{
								client.DefaultRequestHeaders.Add(header.Name, "");
							}
							else
							{
								client.DefaultRequestHeaders.Add(header.Name, header.Value);
							}
						}
					}

					var response = client.GetAsync(url).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		public static async Task<HttpResponseInfo> GetAsync(string url, List<QSParameters> queryStringParameterList, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					url += ParameterBuilder(queryStringParameterList);

					var response = client.GetAsync(url).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		public static async Task<HttpResponseInfo> GetAsync(string url, List<CustomHeaders> customHeaderList, List<QSParameters> queryStringParameterList, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					if (customHeaderList.Count > 0)
					{
						foreach (CustomHeaders header in customHeaderList)
						{
							if (string.IsNullOrEmpty(header.Value))
							{
								client.DefaultRequestHeaders.Add(header.Name, "");
							}
							else
							{
								client.DefaultRequestHeaders.Add(header.Name, header.Value);
							}
						}
					}

					url += ParameterBuilder(queryStringParameterList);

					var response = client.GetAsync(url).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		public static async Task<HttpResponseInfo> PostAsync(string url, object inputModel, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					string body = string.Empty;
					if (inputModel.GetType().Equals(typeof(System.String)))
						body = inputModel.ToString();
					else
						body = JsonConvert.SerializeObject(inputModel);

					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					var response = client.PostAsync(url, new StringContent(body, Encoding.UTF8, contentType)).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		public static async Task<HttpResponseInfo> PostAsync(string url, List<CustomHeaders> customHeaderList, object inputModel, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					string body = string.Empty;
					if (inputModel.GetType().Equals(typeof(System.String)))
						body = inputModel.ToString();
					else
						body = JsonConvert.SerializeObject(inputModel);

					if (customHeaderList.Count > 0)
					{
						foreach (CustomHeaders header in customHeaderList)
						{
							if (string.IsNullOrEmpty(header.Value))
							{
								client.DefaultRequestHeaders.Add(header.Name, "");
							}
							else
							{
								client.DefaultRequestHeaders.Add(header.Name, header.Value);
							}
						}
					}

					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					var response = client.PostAsync(url, new StringContent(body, Encoding.UTF8, contentType)).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		public static async Task<HttpResponseInfo> PostAsync(string url, List<QSParameters> queryStringParameterList, object inputModel, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					string body = string.Empty;
					if (inputModel.GetType().Equals(typeof(System.String)))
						body = inputModel.ToString();
					else
						body = JsonConvert.SerializeObject(inputModel);

					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					url += ParameterBuilder(queryStringParameterList);

					var response = client.PostAsync(url, new StringContent(body, Encoding.UTF8, contentType)).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		public static async Task<HttpResponseInfo> PostAsync(string url, List<CustomHeaders> customHeaderList, List<QSParameters> queryStringParameterList, object inputModel, string accessToken = "", string contentType = "application/json")
		{
			HttpResponseInfo httpResponseInfo = new HttpResponseInfo();
			using (HttpClient client = new HttpClient())
			{
				try
				{
					string body = string.Empty;
					if (inputModel.GetType().Equals(typeof(System.String)))
						body = inputModel.ToString();
					else
						body = JsonConvert.SerializeObject(inputModel);

					if (customHeaderList.Count > 0)
					{
						foreach (CustomHeaders header in customHeaderList)
						{
							if (string.IsNullOrEmpty(header.Value))
							{
								client.DefaultRequestHeaders.Add(header.Name, "");
							}
							else
							{
								client.DefaultRequestHeaders.Add(header.Name, header.Value);
							}
						}
					}

					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

					if (!string.IsNullOrEmpty(accessToken))
					{
						client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
					}

					url += ParameterBuilder(queryStringParameterList);

					var response = client.PostAsync(url, new StringContent(body, Encoding.UTF8, contentType)).Result;

					httpResponseInfo.StatusCode = Convert.ToInt32(response.StatusCode);
					httpResponseInfo.StatusDescription = response.ReasonPhrase;
					httpResponseInfo.Content = await response.Content.ReadAsStringAsync();

					return httpResponseInfo;
				}
				catch (Exception ex)
				{
					httpResponseInfo.StatusCode = 500;
					httpResponseInfo.StatusDescription = "HttpUtil Class Exception";
					httpResponseInfo.Content = ex.ToString();
					return httpResponseInfo;
				}
			}
		}

		private static string ParameterBuilder(List<QSParameters> parameterList)
		{
			string parameters = "?";

			if (parameterList.Count > 0)
			{
				for (int i = 0; i < parameterList.Count; i++)
				{
					if (string.IsNullOrEmpty(parameterList[i].Value))
					{
						parameters += parameterList[i].Name;
					}
					else
					{
						parameters += parameterList[i].Name + "=" + parameterList[i].Value;
					}

					if (i != parameterList.Count - 1)
					{
						parameters += "&";
					}
				}
			}

			return parameters;
		}
		
		public static string Serialize<T>(T obj)
		{
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
			MemoryStream ms = new MemoryStream();
			serializer.WriteObject(ms, obj);
			string retVal = Encoding.UTF8.GetString(ms.ToArray());
			return retVal;
		}

		public static T Deserialize<T>(string json)
		{
			T obj = Activator.CreateInstance<T>();
			MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
			obj = (T)serializer.ReadObject(ms);
			ms.Close();
			return obj;
		}
	}
	public class QSParameters
	{
		public string Name { get; set; }
		public string Value { get; set; }
		
		public QSParameters(string paramName)
		{
			this.Name = paramName;
			this.Value = string.Empty;
		}
		
		public QSParameters(string paramName, string paramValue)
		{
			this.Name = paramName;
			this.Value = paramValue;
		}
	}
	
	public class CustomHeaders
	{
		public string Name { get; set; }
		public string Value { get; set; }
		
		public CustomHeaders(string headerName)
		{
			this.Name = headerName;
			this.Value = string.Empty;
		}
		
		public CustomHeaders(string headerName, string headerValue)
		{
			this.Name = headerName;
			this.Value = headerValue;
		}
	}
	
	public class HttpResponseInfo
	{
		public int StatusCode { get; set; }
		public string StatusDescription { get; set; }
		public string Content { get; set; }
	}

}
