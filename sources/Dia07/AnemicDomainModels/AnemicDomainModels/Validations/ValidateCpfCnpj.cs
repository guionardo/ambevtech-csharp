namespace AnemicDomainModels.Validations;

public static class ValidateCpfCnpj
{
    private static bool IsAllCharEqual(string doc)
    {
        return doc.Select(c => c == doc[0]).Count() == doc.Length;
    }

    public static bool IsValidCpf(string cpf)
    {
        var formattedAccount = cpf.PadLeft(11, '0');

        var multiplicador1 = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        var multiplicador2 = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        formattedAccount = formattedAccount.Trim().Replace(".", "").Replace("-", "");
        if (formattedAccount.Length != 11 || IsAllCharEqual(formattedAccount))
            return false;

        for (var j = 0; j < 10; j++)
            if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == formattedAccount)
                return false;

        var tempCpf = formattedAccount[..9];
        var soma = 0;

        for (var i = 0; i < 9; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

        var resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        var digito = resto.ToString();
        tempCpf += digito;
        soma = 0;
        for (var i = 0; i < 10; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

        resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        digito += resto.ToString();

        return formattedAccount.EndsWith(digito);
    }

    public static bool IsValidCnpj(string cnpj)
    {
        var formattedAccount = cnpj.PadLeft(14, '0');

        var multiplicador1 = new[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        var multiplicador2 = new[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        formattedAccount = formattedAccount.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
        if (formattedAccount.Length != 14 || IsAllCharEqual(formattedAccount))
            return false;

        var tempCnpj = formattedAccount[..12];
        var soma = 0;

        for (var i = 0; i < 12; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

        var resto = soma % 11;
        resto = resto < 2 ? 0 : (11 - resto);

        var digito = resto.ToString();
        tempCnpj += digito;
        soma = 0;
        for (var i = 0; i < 13; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

        resto = soma % 11;
        resto = resto < 2 ? 0 : (11 - resto);

        digito += resto.ToString();

        return formattedAccount.EndsWith(digito);
    }
}