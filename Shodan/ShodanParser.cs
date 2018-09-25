using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shodan.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Shodan
{
    public class ShodanParser
    {
        public static List<ShodanBase> GetData()
        {
            List<ShodanBase> models = new List<ShodanBase>();
            var fileLines = File.ReadAllLines(@"C:\Users\Alex\Documents\Repositories\shodan-parser\shodan_data.json");

            foreach (var line in fileLines)
            {
                ShodanBase model = null;
                var testModel = JsonConvert.DeserializeObject<ShodanTestBase>(line);
                var module = testModel.Metadata.Module;

                if (module == "ftp")
                    model = JsonConvert.DeserializeObject<Ftp>(line);
                else if (module == "ssh")
                    model = JsonConvert.DeserializeObject<OpenSsh>(line);
                else if (module == "smb")
                    model = JsonConvert.DeserializeObject<Smb>(line);
                else if (module == "netbios")
                    model = JsonConvert.DeserializeObject<NetBios>(line);
                else if (module == "ntp")
                    model = JsonConvert.DeserializeObject<Ntp>(line);
                else if (module == "http" || module == "http-simple-new")
                    model = JsonConvert.DeserializeObject<Http>(line);
                else if (module == "https" || module == "https-simple-new")
                    model = JsonConvert.DeserializeObject<Https>(line);
                else if (module == "mdns" || module == "mysql")
                    model = JsonConvert.DeserializeObject<Raw>(line);
                else if (module == "pop3")
                    model = JsonConvert.DeserializeObject<ShodanSslBase>(line);
                else if (module == "imap-ssl")
                    model = JsonConvert.DeserializeObject<ImapSsl>(line);
                else if (module == "nntp" || module == "nodata-tcp" || module == "iscsi" || module == "iscsi" || module == "xmpp"
                        || module == "portmap-tcp" || module == "rtsp-tcp" || module == "line-printer-daemon" || module == "smtp"
                        || module == "imap")
                    model = JsonConvert.DeserializeObject<ShodanBase>(line);

                if (model is null) throw new Exception();
                models.Add(model);
            }

            return models;
        }
    }
}
