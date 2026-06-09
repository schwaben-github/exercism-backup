two_fer <- function(input) {
  if(missing("input")){
    print("One for you, one for me.")
  } else {
    print(paste0("One for ", input, ", one for me.", sep = ""))
  }
}
