using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
	class clsAppointment
	{
		public int id;

		public int idPasien { set; get; }

		public int idDokter { set; get; }

		public DateTime time {set;get;}

		public clsAppointment(int id, int idPasien, int idDokter, DateTime time)
		{
			this.id = id;
			this.idPasien = idPasien;
			this.idDokter = idDokter;
			this.time = time;
		}

		public void detailAppointment()
		{

		}

		public void alterAppointment(int id, int idPasien, int idDokter, DateTime time)
		{
			this.id = id;
			this.idPasien = idPasien;
			this.idDokter = idDokter;
			this.time = time;
		}

		public void alterAppointment(DateTime time)
		{
			this.time = time;
		}

		public void alterAppointment(int idPasien, int idDokter)
		{
			this.idPasien = idPasien;
			this.idDokter = idDokter;
		}

		public void alterAppointment(int idPasien)
		{
			this.idPasien = idPasien;
		}

		public void alterAppointment(int idDokter)
		{
			this.idDokter = idDokter;
		}
	}
}