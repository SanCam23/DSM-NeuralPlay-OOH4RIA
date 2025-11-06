

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class PerfilCEN
 *
 */
public partial class PerfilCEN
{
private IPerfilRepository _IPerfilRepository;

public PerfilCEN(IPerfilRepository _IPerfilRepository)
{
        this._IPerfilRepository = _IPerfilRepository;
}

public IPerfilRepository get_IPerfilRepository ()
{
        return this._IPerfilRepository;
}

public void Destroy (int id
                     )
{
        _IPerfilRepository.Destroy (id);
}

public PerfilEN ReadOID (int id
                         )
{
        PerfilEN perfilEN = null;

        perfilEN = _IPerfilRepository.ReadOID (id);
        return perfilEN;
}

public System.Collections.Generic.IList<PerfilEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PerfilEN> list = null;

        list = _IPerfilRepository.ReadAll (first, size);
        return list;
}
}
}
