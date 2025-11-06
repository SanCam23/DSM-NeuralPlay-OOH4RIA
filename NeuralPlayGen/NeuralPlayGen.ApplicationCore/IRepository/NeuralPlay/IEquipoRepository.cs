
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IEquipoRepository
{
void setSessionCP (GenericSessionCP session);

EquipoEN ReadOIDDefault (int id
                         );

void ModifyDefault (EquipoEN equipo);

System.Collections.Generic.IList<EquipoEN> ReadAllDefault (int first, int size);



int New_ (EquipoEN equipo);

void Modify (EquipoEN equipo);


void Destroy (int id
              );


EquipoEN ReadOID (int id
                  );


System.Collections.Generic.IList<EquipoEN> ReadAll (int first, int size);
}
}
