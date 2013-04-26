using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BattleshipClient {
	class Hajok {
		private Point _hely;
		private Bitmap hkep;

		public Point Hely {
			get { return _hely; }
			set { _hely = value; }
		}
		

		public Bitmap Hkep {
			get { return hkep; }
			set { hkep = value; }
		}

		public Hajok(int x, int y, Bitmap k, Size s) {
			_hely = new Point(x, y);
			hkep = new Bitmap(k, s);
			
		}
	}
}
