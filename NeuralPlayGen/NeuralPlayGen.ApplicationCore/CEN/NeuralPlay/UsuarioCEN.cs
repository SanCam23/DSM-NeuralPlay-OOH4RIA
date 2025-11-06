

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioRepository _IUsuarioRepository;

public UsuarioCEN(IUsuarioRepository _IUsuarioRepository)
{
        this._IUsuarioRepository = _IUsuarioRepository;
}

public IUsuarioRepository get_IUsuarioRepository ()
{
        return this._IUsuarioRepository;
}

public int New_ (String p_pass, string p_nick, string p_correoElectronico, string p_telefono, Nullable<DateTime> p_fechaRegistro, bool p_estadoCuenta, int p_perfil)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        usuarioEN.Nick = p_nick;

        usuarioEN.CorreoElectronico = p_correoElectronico;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.FechaRegistro = p_fechaRegistro;

        usuarioEN.EstadoCuenta = p_estadoCuenta;


        if (p_perfil != -1) {
                // El argumento p_perfil -> Property perfil es oid = false
                // Lista de oids id
                usuarioEN.Perfil = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN ();
                usuarioEN.Perfil.Id = p_perfil;
        }



        oid = _IUsuarioRepository.New_ (usuarioEN);
        return oid;
}

public void Modify (int p_Usuario_OID, String p_pass, string p_nick, string p_correoElectronico, string p_telefono, Nullable<DateTime> p_fechaRegistro, bool p_estadoCuenta)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        usuarioEN.Nick = p_nick;
        usuarioEN.CorreoElectronico = p_correoElectronico;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.FechaRegistro = p_fechaRegistro;
        usuarioEN.EstadoCuenta = p_estadoCuenta;
        //Call to UsuarioRepository

        _IUsuarioRepository.Modify (usuarioEN);
}

public void Destroy (int id
                     )
{
        _IUsuarioRepository.Destroy (id);
}

public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.ReadOID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioRepository.ReadAll (first, size);
        return list;
}
}
}
