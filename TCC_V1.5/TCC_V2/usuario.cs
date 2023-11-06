using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC_V2
{
    public class usuario
    {

        public String usuario_id;
        public int usuario_vota = 0;

        public void SetUsuarioId(String _usuario_id)
        {
            usuario_id = _usuario_id;
        }

        public String GetUsuarioId()
        {
            return usuario_id;
        }

        public void SetUsuarioV(int _usuario_vota)
        {
            usuario_vota = _usuario_vota;
        }

        public int GetUsuarioV()
        {
            return usuario_vota;
        }


    }
}