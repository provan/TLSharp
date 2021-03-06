using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(2139689491)]
    public class TLUpdateWebPage : TLAbsUpdate
    {
        public override int Constructor
        {
            get
            {
                return 2139689491;
            }
        }

             public TLAbsWebPage webpage {get;set;}
     public int pts {get;set;}
     public int pts_count {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            webpage = (TLAbsWebPage)ObjectUtils.DeserializeObject(br);
pts = br.ReadInt32();
pts_count = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(webpage,bw);
bw.Write(pts);
bw.Write(pts_count);

        }
    }
}
