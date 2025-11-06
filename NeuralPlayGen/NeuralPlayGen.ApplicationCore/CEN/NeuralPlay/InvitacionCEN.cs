

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class InvitacionCEN
 *
 */
public partial class InvitacionCEN
{
private IInvitacionRepository _IInvitacionRepository;

public InvitacionCEN(IInvitacionRepository _IInvitacionRepository)
{
        this._IInvitacionRepository = _IInvitacionRepository;
}

public IInvitacionRepository get_IInvitacionRepository ()
{
        return this._IInvitacionRepository;
}

public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum p_tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum p_estado, Nullable<DateTime> p_fechaEnvio, int p_comunidad, int p_emisor)
{
        InvitacionEN invitacionEN = null;
        int oid;

        //Initialized InvitacionEN
        invitacionEN = new InvitacionEN ();
        invitacionEN.Tipo = p_tipo;

        invitacionEN.Estado = p_estado;

        invitacionEN.FechaEnvio = p_fechaEnvio;


        if (p_comunidad != -1) {
                // El argumento p_comunidad -> Property comunidad es oid = false
                // Lista de oids id
                invitacionEN.Comunidad = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN ();
                invitacionEN.Comunidad.Id = p_comunidad;
        }


        if (p_emisor != -1) {
                // El argumento p_emisor -> Property emisor es oid = false
                // Lista de oids id
                invitacionEN.Emisor = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                invitacionEN.Emisor.Id = p_emisor;
        }



        oid = _IInvitacionRepository.New_ (invitacionEN);
        return oid;
}

public void Modify (int p_Invitacion_OID, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum p_tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum p_estado, Nullable<DateTime> p_fechaEnvio)
{
        InvitacionEN invitacionEN = null;

        //Initialized InvitacionEN
        invitacionEN = new InvitacionEN ();
        invitacionEN.Id = p_Invitacion_OID;
        invitacionEN.Tipo = p_tipo;
        invitacionEN.Estado = p_estado;
        invitacionEN.FechaEnvio = p_fechaEnvio;
        //Call to InvitacionRepository

        _IInvitacionRepository.Modify (invitacionEN);
}

public void Destroy (int id
                     )
{
        _IInvitacionRepository.Destroy (id);
}

public InvitacionEN ReadOID (int id
                             )
{
        InvitacionEN invitacionEN = null;

        invitacionEN = _IInvitacionRepository.ReadOID (id);
        return invitacionEN;
}

public System.Collections.Generic.IList<InvitacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<InvitacionEN> list = null;

        list = _IInvitacionRepository.ReadAll (first, size);
        return list;
}
}
}
