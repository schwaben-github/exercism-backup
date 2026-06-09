score <- function(x, y) {
  dst <- sqrt(x^2 + y^2)

  if(dst <= 1.0) {
    return(10)
  }
  else if(dst > 1.0 && dst <= 5.0) {
    return(5)
  }
  else if(dst > 5.0 && dst <= 10.0) {
    return(1)
  }
  else if(dst > 10.0){
    return(0)
  }
}
