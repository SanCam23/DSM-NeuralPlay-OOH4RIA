

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class MensajeChatCEN
 *
 */
public partial class MensajeChatCEN
{
private IMensajeChatRepository _IMensajeChatRepository;

public MensajeChatCEN(IMensajeChatRepository _IMensajeChatRepository)
{
        this._IMensajeChatRepository = _IMensajeChatRepository;
}

public IMensajeChatRepository get_IMensajeChatRepository ()
{
        return this._IMensajeChatRepository;
}

public int New_ (string p_contenido, Nullable<DateTime> p_fechaEnvio, int p_chatEquipo, int p_usuario)
{
        MensajeChatEN mensajeChatEN = null;
        int oid;

        //Initialized MensajeChatEN
        mensajeChatEN = new MensajeChatEN ();
        mensajeChatEN.Contenido = p_contenido;

        mensajeChatEN.FechaEnvio = p_fechaEnvio;


        if (p_chatEquipo != -1) {
                // El argumento p_chatEquipo -> Property chatEquipo es oid = false
                // Lista de oids id
                mensajeChatEN.ChatEquipo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN ();
                mensajeChatEN.ChatEquipo.Id = p_chatEquipo;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                mensajeChatEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                mensajeChatEN.Usuario.Id = p_usuario;
        }



        oid = _IMensajeChatRepository.New_ (mensajeChatEN);
        return oid;
}

public void Modify (int p_MensajeChat_OID, string p_contenido, Nullable<DateTime> p_fechaEnvio)
{
        MensajeChatEN mensajeChatEN = null;

        //Initialized MensajeChatEN
        mensajeChatEN = new MensajeChatEN ();
        mensajeChatEN.Id = p_MensajeChat_OID;
        mensajeChatEN.Contenido = p_contenido;
        mensajeChatEN.FechaEnvio = p_fechaEnvio;
        //Call to MensajeChatRepository

        _IMensajeChatRepository.Modify (mensajeChatEN);
}

public void Destroy (int id
                     )
{
        _IMensajeChatRepository.Destroy (id);
}

public MensajeChatEN ReadOID (int id
                              )
{
        MensajeChatEN mensajeChatEN = null;

        mensajeChatEN = _IMensajeChatRepository.ReadOID (id);
        return mensajeChatEN;
}

public System.Collections.Generic.IList<MensajeChatEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MensajeChatEN> list = null;

        list = _IMensajeChatRepository.ReadAll (first, size);
        return list;
}
}
}
