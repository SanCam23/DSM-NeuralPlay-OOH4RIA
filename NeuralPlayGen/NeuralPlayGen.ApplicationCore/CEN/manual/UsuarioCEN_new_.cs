
using System;
using System.Text;
using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CEN.NeuralPlay_Usuario_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
public partial class UsuarioCEN
{
public int New_ (String p_pass, string p_nick, string p_correoElectronico, string p_telefono, Nullable<DateTime> p_fechaRegistro, int p_perfil)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CEN.NeuralPlay_Usuario_new__customized) ENABLED START*/

        // --- INICIO VALIDACI�N CUSTOM ---
        // Comprobamos si el nick es igual a la contrase�a (ignorando may�sculas/min�sculas por seguridad)
        if (p_nick.Equals (p_pass, StringComparison.OrdinalIgnoreCase)) {
                throw new ArgumentException ("Por seguridad, el nick y la contrase�a no pueden ser iguales.");
        }
        // --- FIN VALIDACI�N CUSTOM ---

        UsuarioEN usuarioEN = null;

        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        // OJO: Aqu� est�s hasheando la contrase�a. La comparaci�n debe hacerse ANTES de esto (como he puesto arriba).
        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        usuarioEN.Nick = p_nick;

        usuarioEN.CorreoElectronico = p_correoElectronico;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.FechaRegistro = p_fechaRegistro;


        if (p_perfil != -1) {
                usuarioEN.Perfil = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN ();
                usuarioEN.Perfil.Id = p_perfil;
        }
        usuarioEN.EstadoCuenta = true;
        //Call to UsuarioRepository

        oid = _IUsuarioRepository.New_ (usuarioEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
