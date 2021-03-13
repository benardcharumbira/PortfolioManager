export const getCompanies = async () => {
  var response = await fetch("company/getcompanies");
  var data = await response.json();
  return data;
};

export const getCompanySectors = async () => {
  var response = await fetch("sector/getcompanysectors");
  var data = await response.json();
  return data;
};
